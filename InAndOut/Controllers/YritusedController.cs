using InAndOut.Data;
using InAndOut.Models;
using InAndOut.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class YritusedController : Controller
    {
        private readonly ApplicationDbContext _db;

        public YritusedController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Yritused> objList = _db.Yritused;
            return View(objList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Yritused obj)
        {
            _db.Yritused.Add(obj);
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
            var obj = _db.Yritused.Find(id);
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
            var obj = _db.Yritused.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Yritused.Remove(obj);
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
            var obj = _db.Yritused.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        // Post Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Yritused obj)
        {
            _db.Yritused.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {

           
           
            PersonUritusViewModel obj = new PersonUritusViewModel()
            {
                yritused = _db.Yritused,
                people = _db.Persons,
                GetYritused = _db.Yritused.Find(id),
                
                
              
            };
            
                 
    
            return View(obj);
        }

        

    }
}
