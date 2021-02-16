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

        public async Task<IActionResult> CreateReservation([Bind("ID,BookID,CustomerID,RequestedAt")]Reservation reservation)
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
            var query = await _context.Books
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
                        customerID = reservation.CustomerID
                    }
                )
                .Join(_context.Users, res => res.customerID, user => user.ID,
                (res, user) => new ReservationsVm(
                     res.ID,
                     res.bookID,
                     res.bookISBN,
                     res.bookName,
                     res.bookAuthor,
                     res.requestedAt,
                     res.customerID,
                     user.FullName
                )).ToListAsync();
            // why not async+await if we have to wait for database call, and don't want the app to block

            return View(query);
        }


        public  ActionResult Transactions()
        {
            return View();
        }

        public async  Task<ActionResult> AcceptReservation(int id)
        {
            var query = _context.Reservations.Where(e => e.ID == id);
            await query
                .Join(_context.Users, res => res.CustomerID, user => user.ID,
                (res, user) => new
                    {
                        ID = res.ID,
                        userID = res.CustomerID,
                        fullName = user.FullName,
                        requestedAt = res.RequestedAt
                    }
                )
                .Join(_context.Books, res => res.ID, book => book.ID,
                (res,book) => new Order(
                
                )
                ).ToListAsync();

            var isSuccessful = await _context.SaveChangesAsync();
            if (isSuccessful != 0)
                TempData["reservationAcceptance"] = "reservation was successfully accepted.";
            else
                TempData["reservationAcceptance"] = "reservation acceptance failed.";
            return RedirectToAction("Reservations", "Order");
        }

        public async Task<ActionResult> DeclineReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            var isSuccessful=await _context.SaveChangesAsync();
            if (isSuccessful != 0)
                TempData["reservationDeletion"] = "reservation was successfully deleted.";
            else
                TempData["reservationDeletion"] = "reservation deletion failed.";
            return RedirectToAction("Reservations", "Order");
        }
    }
}