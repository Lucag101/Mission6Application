using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6Application.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Application.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext MovieContext { get; set; }
        public object Context { get; private set; }

        public HomeController(MovieApplicationContext someName)
        {
            MovieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Category = MovieContext.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                MovieContext.Add(ar);
                MovieContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Category = MovieContext.Category.ToList();
                return View(ar);
            }
        }

        // Display Movies, and include the Category table
        [HttpGet]
        public IActionResult MovieDisplay()
        {
            var applications = MovieContext.responses.
                Include(n=> n.Category).
                OrderBy(n=> n.CategoryId)
                .ToList();
            return View(applications);
        }
       
        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Category = MovieContext.Category.ToList();
            var application = MovieContext.responses.Single(x=> x.ApplicationId == applicationid);
            
            return View("Movies", application);
        }
        
        [HttpPost]
        public IActionResult Edit(ApplicationResponse info)
        {
            if (ModelState.IsValid)
            {
                MovieContext.Update(info);
                MovieContext.SaveChanges();
                return RedirectToAction("MovieDisplay");
            }
            else
            {
                ViewBag.Category = MovieContext.Category.ToList();
                return View("Movies",info);
            }
        }
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application =  MovieContext.responses.Single(x => x.ApplicationId == applicationid);
            return View(application);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            MovieContext.responses.Remove(ar);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieDisplay");
        }
    }
}
