﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private IReviewDAO reviewDAO;

        public HomeController(IReviewDAO reviewDAO)
        {
            this.reviewDAO = reviewDAO;
        }
        public ActionResult Index()
        {
            IList<Review> reviews = reviewDAO.GetAllReviews();
            return View(reviews);
            
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]

        public IActionResult NewReview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReview(Review review)
        {
            reviewDAO.SaveReview(review);

            return RedirectToAction("Index");
        }
    }
}

