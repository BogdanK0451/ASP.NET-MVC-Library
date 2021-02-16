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
    }
}