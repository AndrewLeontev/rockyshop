using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockyShop.Data;
using RockyShop.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RockyShop.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReviewsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Review> reviews = _db.Reviews;
            return View(reviews);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Review obj)
        {
            if (ModelState.IsValid)
            {
                obj.CreatedAt = DateTime.Now;
                obj.UpdatedAt = DateTime.Now;
                _db.Reviews.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Reviews.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, Review review)
        {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Reviews.Find(id);
            if (obj == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                obj.UpdatedAt = DateTime.Now;
                _db.Reviews.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Reviews.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id, Review review)
        {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Reviews.Find(id);
            if (obj == null)
                return NotFound();

            _db.Reviews.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
