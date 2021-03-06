﻿namespace Library.Controllers
{
    using Library.Models;
    using Library.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderController : Controller
    {
        private readonly LibraryContext _context;

        public OrderController(LibraryContext context)
        {
            _context = context;
        }
        /*reservation should've been created based on bookISBN not bookID, bookISBN is unique, but we'll refactor the database and code at a later point*/
        public async Task<IActionResult> CreateReservation([Bind("ID,BookID,UserID,RequestedAt")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                int isSuccessful = await _context.SaveChangesAsync();

                if (isSuccessful != 0)
                    TempData["reservationProcessed"] = "Reservation is being processed";
                else
                    TempData["reservationProcessed"] = "Oops, something went wrong";
                return RedirectToAction("Shelves", "Book");
            }
            return RedirectToAction("Shelves", "Book");
        }

        public async Task<ActionResult> Reservations()
        {
            var query = _context.Books
                .Join(_context.Reservations,
                    book => book.ID,
                    reservation => reservation.BookID,
                    (book, reservation) => new
                    {
                        ID = reservation.ID,
                        bookID = book.ID,
                        bookISBN = book.Isbn,
                        bookName = book.Title,
                        bookAuthor = book.Author,
                        requestedAt = reservation.RequestedAt,
                        userID = reservation.UserID
                    }
                )
                .Join(_context.Users, res => res.userID, user => user.ID,
                (res, user) => new ReservationsVm(
                     res.ID,
                     res.bookID,
                     res.bookISBN,
                     res.bookName,
                     res.bookAuthor,
                     res.requestedAt,
                     res.userID,
                     user.FullName
                ));
            var reservationsVm = await query.ToListAsync();
            return View(reservationsVm);
        }

        public async Task<ActionResult> Transactions()
        {
            var query = _context.Orders
                .Join(_context.Books,
                    order => order.BookID,
                    book => book.ID,
                    (order, book) => new
                    {
                        order1 = order,
                        book1 = book,
                    }
                )
                .Join(_context.Users, res => res.order1.UserID, user => user.ID,
                (res, user) => new OrderVm(res.order1, user.FullName, res.book1.Isbn, res.book1.Title, res.book1.Author)
                );
            var orders = await query.ToListAsync();

            return View(orders);
        }

        //this gets complicated because the way the Book schema was defined
        /* Problem happens because the reservation gets bound to the ID of the Book. 
         * And because of the way the code is structured if 1 copy of a specific Book is reserved, other copies won't be able to be reserved.
         Because of that bad implementation we have to query for the book with the specified ID and then query for all books of the same ISBN as that book*/
        public async Task<ActionResult> AcceptReservation(int id)
        {   // find the reservation we want to accept

            var queryableReservations = _context.Reservations.Where(r => r.ID == id);
            var reservation = await queryableReservations.FirstAsync();

            var queryable = _context.Orders.Where(o => o.UserID == reservation.UserID && o.Status=="active");
            var orders = await queryable.ToListAsync();

            if (orders.Count() < 5)
            {
                //finding the book with BookID from reservation
                var queryableBooks = _context.Books.Where(b => b.ID == reservation.BookID);
                var book = await queryableBooks.FirstAsync();
                //finding all books with the same BookISBN as the book with given BookID
                var queryableBooks2 = _context.Books.Where(b => b.Isbn == book.Isbn && !b.Borrowed);
                var orderableBook = await queryableBooks2.FirstOrDefaultAsync();
                // if copy of the book that isn't in use exists
                if (!(orderableBook == null))
                {
                    reservation.BookID = orderableBook.ID;
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();

                    var query4 = _context.Reservations.Where(r => r.ID == id);
                    var query5 = query4
                        .Join(_context.Users, res => res.UserID, user => user.ID,
                        (res, user) => new
                        {
                            ID = res.ID,
                            bookID = res.BookID,
                            userID = res.UserID,
                            fullName = user.FullName,
                        }
                        )
                        .Join(_context.Books, res => res.bookID, book => book.ID,
                        (res, book) => new Order(
                            res.ID, res.userID, res.bookID
                        ));

                    var order = await query5.FirstAsync();
                    reservation = await _context.Reservations.FindAsync(id);
                    var user = await _context.Users.FindAsync(reservation.UserID);

                    user.BooksHeld++;
                    user.TotalBooksBorrowed++;
                    orderableBook.TimesBorrowed++;
                    orderableBook.Borrowed = true;

                    // is there a need to check if model state is valid if i'm not creating an entry??
                    if (ModelState.IsValid)
                    {
                        _context.Users.Update(user);
                        _context.Books.Update(orderableBook);
                        _context.Orders.Add(order);
                        _context.Reservations.Remove(reservation);

                        var isSuccessful = await _context.SaveChangesAsync();
                        if (isSuccessful != 0)
                        {
                            TempData["reservationAcceptance"] = "Reservation was successfully accepted.";
                            BorrowedBook borrowedBook = new BorrowedBook(reservation.UserID, reservation.BookID, order.ID);
                            _context.BorrowedBooks.Add(borrowedBook);
                            await _context.SaveChangesAsync();
                        }
                        else
                            TempData["reservationAcceptance"] = "Reservation acceptance failed.";
                    }
                }
                else
                    TempData["noBookCopies"] = "No book copies remaining, decline the reservation";
            }
            else
                TempData["noBookCopies"] = "User has already reserved more than 5 books";
            return RedirectToAction("Reservations", "Order");
        }

        public async Task<ActionResult> DeclineReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            _context.Reservations.Remove(reservation);
            var isSuccessful = await _context.SaveChangesAsync();
            if (isSuccessful != 0)
                TempData["reservationDeletion"] = "Reservation was successfully deleted.";
            else
                TempData["reservationDeletion"] = "Reservation deletion failed.";
            return RedirectToAction("Reservations", "Order");
        }
    }
}
