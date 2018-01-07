using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoDbFirstAproach.Models;

namespace DemoDbFirstAproach.Controllers
{
    public class ActorController : Controller
    {
        private ActorDbContext _dbContext;

        public ActorController(ActorDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.Actors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actors actor)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(actor);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

    }
}