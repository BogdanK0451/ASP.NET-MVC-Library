using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using System.Net.Mail;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Http;



namespace Library.Controllers
{
    public class UserController : Controller
    {
        const string SessionId = "id";
        const string SessionEmail = "email";
        const string SessionAccessLevel = "accessLevel";
        const string SessionName = "userName";

        const string LOGGED_OUT = "0";

        private readonly LibraryContext _context;

        public UserController(LibraryContext context)
        {
            _context = context;
        }
        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        // GET: User/Create  , add new user
        public IActionResult Sign_Up()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sign_Up([Bind("ID,FirstName,LastName,Email,Password,ConfirmPassword,PermissionLevel,BooksHeld")] User user)
        {
            //checking if email already exists in the database
            var queryableResult = _context.Users.Where(u => u.Email == user.Email);
            var query = queryableResult.ToList();
            if (ModelState.IsValid && !query.Any())
            {

                // authentication issues
                //SendEmail(user.Email, "Your Library Account", "Congratulations!\n Your account has been Successfully created!");

                //success, hence, show the user that he succesfully created an account
                TempData["Success"] = "Congratulations, you've successfully created an account, feel free to sign in";
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Failure"] = "Sorry, the email is already taken";
                return RedirectToAction("Index", "Home");
            }
        }
        // GET: User/Sign_In
        public IActionResult Sign_In()
        {
            return View();
        }
        // POST: User/Sign_In
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sign_In(string email, string password)
        {
   
            var queryableResult = _context.Users.Where(u => u.Email == email && u.Password == password);
            var query = queryableResult.ToList();

            //if query result empty
            if (!query.Any()) {
                TempData["Failure"] = "Sorry, email or password was incorrect, try again.";
                return RedirectToAction("Index", "Home");
            }
            else {

                foreach (var el in query)
                {
                    HttpContext.Session.SetString(SessionId, el.ID.ToString());
                    HttpContext.Session.SetString(SessionEmail, el.Email);
                    HttpContext.Session.SetString(SessionAccessLevel, el.PermissionLevel.ToString());
                    HttpContext.Session.SetString(SessionName, el.FullName);
                }
                TempData["Success"] = "You've successfully logged in!";
                return RedirectToAction("Index", "Home");
            }
        }


        // GET: Index page
        public IActionResult Sign_Out()
        {
            HttpContext.Session.Remove(SessionId);
            HttpContext.Session.Remove(SessionEmail);
            HttpContext.Session.SetString(SessionAccessLevel, LOGGED_OUT);
            HttpContext.Session.Remove(SessionName);
            return RedirectToAction("Index", "Home");
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }


        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Email,Password,PermissionLevel,BooksHeld")] User user)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
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
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.ID == id);
        }

        public void SendEmail(string toEmail, string subject, string emailBody)
        {
            string senderEmail = "projectsendemail@gmail.com";
            string senderPassword = "emailsender123";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = true;
            client.EnableSsl = true;
            client.Timeout = 500000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(senderEmail, senderPassword);
            MailMessage mailMessage = new MailMessage(senderEmail, toEmail, subject, emailBody);
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = UTF8Encoding.UTF8;
            client.Send(mailMessage);
        }
    }
}
