using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PersonController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Person> objList = _db.Persons;
            return View(objList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person obj)
        {
            _db.Persons.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Persons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Persons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Persons.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        // GET Update
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Persons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        // Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Person obj)
        {
            _db.Persons.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            var det = _db.Persons.Find(id);
            return View(det);
        }

    }
}
