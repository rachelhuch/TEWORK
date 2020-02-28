using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.DAL;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class FilmsController : Controller
    {
        public IActionResult Index()
        {
            //Get a list of all films
            IStarWarsDAO dao = new MockStarWarsDAO();
            //Ilist of films
            IList<Film>films=dao.GetFilms();

            //pass in list that we just created
            return View(films);
            //could also do return View("Index", films); and that would work
        }

        public IActionResult Detail(string id)
        {
            //find the film with the given id and display it in a default view

            IStarWarsDAO dao = new MockStarWarsDAO();
            Film film = dao.GetFilm(id);
            if (film==null)
            {
                return NotFound();
            }
            else
            {
                return View();
            }
           
        }
    }
}