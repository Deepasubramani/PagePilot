using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PagePilot.Data;
using PagePilot.Models;
using System.Security.Claims;

namespace PagePilot.Controllers
{
    public class UserBookMarksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserBookMarksController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var userMovies = _context.UserFavorites.Where(x => x.UserId == userId);
                var model = userMovies.Select(x => new BookmarkView
                {
                    UserId = x.UserId
                }).ToList();

                return View(model);
            }
            else
            {
                return View();
            }
        }
    }
}
