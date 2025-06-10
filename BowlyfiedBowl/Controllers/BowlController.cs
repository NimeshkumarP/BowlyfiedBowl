using Microsoft.AspNetCore.Mvc;
using BowlyfiedBowl.Data;
using BowlyfiedBowl.Models;
using System.Linq;

namespace BowlyfiedBowl.Controllers
{
    public class BowlyfiedBowl : Controller
    {
        private readonly ApplicationDbContext _context;

        public BowlyfiedBowl(ApplicationDbContext context)
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
        public IActionResult Create(Bowl bowls)
        {
            if (ModelState.IsValid)
            {
                _context.Bowls.Add(bowls);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bowls);
        }
    }
}
