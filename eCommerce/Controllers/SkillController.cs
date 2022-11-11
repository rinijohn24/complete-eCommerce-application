using eCommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Skills.ToList();
            return View(data);
        }
    }
}
