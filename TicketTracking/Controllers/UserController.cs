using Microsoft.AspNetCore.Mvc;
using TicketTracking.DataAccess;

namespace TicketTracking.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDBContext _context;

        public UserController(UserDBContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View();
        }
    }
}
