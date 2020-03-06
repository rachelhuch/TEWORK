using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;


namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public IActionResult Index()
        {
            return View("Index");
        }


        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel loginvm)
        {

            //if not valid it's going to return the post with the error message and if it is valid then all is fine

            if (!ModelState.IsValid)
            {
                return View(loginvm);
            }

            TempData["Message"] = $"You have successfully logged in!";
            return RedirectToAction("Confirmation");
        }

        // GET: User/Register
        // Return the empty registration view

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the
        // registration view (if validation fails)

        // GET: User/Login
        // Return the empty login view

        // POST: User/login
        // Validate the model and redirect to a confirmation page if validation is
        // successful. Return the login view (if validation fails).

        // GET: User/Confirmation
        // Return the confirmation view

        [HttpGet]

        public IActionResult Confirmation()
        {
            return View();
        }



        [HttpGet]

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Registration(RegistrationViewModel registrationvm)
        {

            //if not valid it's going to return the post with the error message and if it is valid then all is fine

            if (!ModelState.IsValid)
            {
                return View(registrationvm);
            }

            TempData["Message"] = $"You have successfully registered";
            return RedirectToAction("Confirmation");
        }
    }
}