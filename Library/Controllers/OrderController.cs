using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.ViewModels;
using static System.Diagnostics.Debug;

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
        public ActionResult Reservations()
        {
            var query = _context.Books
                .Join(_context.Reservations,
                    book => book.ID,
                    reservation => reservation.BookID,
                    (book, reservation) => new
                    {
                        reservationID = reservation.ID,
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
                     res.reservationID,
                     res.bookID,
                     res.bookISBN,
                     res.bookName,
                     res.bookAuthor,
                     res.requestedAt,
                     res.customerID,
                     user.FullName
                )).ToList();
            // why not async+await if we have to wait for database call, and don't want the app to block

            return View(query);
        }


        public  ActionResult Transactions()
        {
            return View();
        }
    }
}