namespace Library.Controllers
{
    using Library.Models;
    using Library.ViewModels;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class BookController : Controller
    {
        private readonly LibraryContext _context;

        public int BOOKS_HELD = 0;

        public BookController(LibraryContext context)
        {
            _context = context;
        }

        //POST:Book/Returned
        public async Task<IActionResult> Returned(int bookId, int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            var borrowedBook = await _context.BorrowedBooks.Where(b => b.OrderID == orderId).FirstAsync();
            var book = await _context.Books.FindAsync(bookId);
            var user = await _context.Users.FindAsync(order.UserID);

            user.BooksHeld--;
            order.ReturnedOn = DateTime.Now;
            order.Status = "completed";
            book.Borrowed = false;

            // this just "tells the database what needs to be done but doesn't do anythign"
            _context.Update(order);
            _context.Update(book);
            _context.Update(user);
            _context.Remove(borrowedBook);

            //this does the trick
            await _context.SaveChangesAsync();

            return RedirectToAction("Transactions", "Order");
        }

        // GET: Book/Shelves
        public async Task<IActionResult> Shelves()
        {
            if (HttpContext.Session.GetString("id") != null)
            {
                // is it fine using tempdata in the views?
                var user = await _context.Users.Where(u => u.ID == Int32.Parse(HttpContext.Session.GetString("id"))).SingleAsync();
                TempData["booksHeld"] = user.BooksHeld;
            }
            else
                TempData["booksHeld"] = BOOKS_HELD;
            return View(await _context.Books.ToListAsync());
        }

        // GET: Book/Popular
        public async Task<IActionResult> Popular()
        {
            /* NOT IMPLEMENTED YET */

            var popularBooks = await _context.Books.OrderByDescending(b => b.TimesBorrowed).Take(3).ToListAsync();

            return View();
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            //BooksAndGenres booksandgenres= new BooksAndGenres();
            //booksandgenres.Genres = _context.Genres.ToList();
            //ViewData["booksandgenres"] = booksandgenres;
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Isbn,Title,Author,Genre,YearWritten,Pages,Summary,Borrowed")] Book book)
        {
            if (ModelState.IsValid)
            {
                book.ImageUrl = "/images/" + book.Title + ".jpg";
                _context.Add(book);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Isbn,Title,Author,Genre,YearWritten,Pages,Summary")] Book book)
        {
            if (id != book.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.ID == id);
        }
    }
}
