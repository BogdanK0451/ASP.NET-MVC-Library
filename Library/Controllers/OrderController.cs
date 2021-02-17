using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Library.ViewModels;


namespace Library.Controllers
{
    public class OrderController : Controller
    {
        private readonly LibraryContext _context;

        public OrderController(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CreateReservation([Bind("ID,BookID,UserID,RequestedAt")]Reservation reservation)
        {
            // BooksAndReservations booksandreservations = new BooksAndReservations();
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
            var query =_context.Books
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

        public async  Task<ActionResult> AcceptReservation(int id)
        {  
            var query = _context.Reservations.Where(r => r.ID == id);
            var query2 = query
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

            var order = await query2.FirstAsync();
            var reservation = await _context.Reservations.FindAsync(id);
            var book = await _context.Books.FindAsync(reservation.BookID);
            var user = await _context.Users.FindAsync(reservation.UserID);

            user.TotalBooksBorrowed++;
            book.TimesBorrowed++;
            book.Borrowed = true;

            // is there a need to check if model state is valid if i'm not creating an entry??
            if (ModelState.IsValid)
            {
                _context.Books.Update(book);
                _context.Orders.AddRange(order);
                _context.Reservations.Remove(reservation);

                var isSuccessful = await _context.SaveChangesAsync();
                if (isSuccessful != 0)
                {
                    TempData["reservationAcceptance"] = "reservation was successfully accepted.";
                    BorrowedBook borrowedBook = new BorrowedBook(reservation.UserID, reservation.BookID,order.ID);
                    _context.BorrowedBooks.Add(borrowedBook);
                    await _context.SaveChangesAsync();
                }
                else
                    TempData["reservationAcceptance"] = "reservation acceptance failed.";
                return RedirectToAction("Reservations", "Order");
            }
            return RedirectToAction("Reservations", "Order");
        }

        public async Task<ActionResult> DeclineReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            _context.Reservations.Remove(reservation);
            var isSuccessful = await _context.SaveChangesAsync();
            if (isSuccessful != 0)
                TempData["reservationDeletion"] = "reservation was successfully deleted.";
            else
                TempData["reservationDeletion"] = "reservation deletion failed.";
            return RedirectToAction("Reservations", "Order");

        }
    }
}