using eCommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Controllers
{
    public class PublicationController : Controller
    {
        private readonly AppDbContext _context;

        public PublicationController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPublications = await _context.Publication.ToListAsync();
            return View();
        }
    }
}
