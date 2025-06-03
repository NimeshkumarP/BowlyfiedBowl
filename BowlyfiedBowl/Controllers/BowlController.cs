using Microsoft.AspNetCore.Mvc;
using BolyfiedApp.Data;
using BolyfiedBowl.Models;
using System.Linq;

namespace BolyfiedApp.Controllers
{
    public class BowlController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BowlController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bowls = _context.Bowls.ToList();
            return View(bowls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bowl bowl)
        {
            if (ModelState.IsValid)
            {
                _context.Bowls.Add(bowl);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bowl);
        }
    }
}
