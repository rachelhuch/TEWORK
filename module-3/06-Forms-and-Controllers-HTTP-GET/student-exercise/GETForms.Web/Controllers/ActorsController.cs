using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class ActorsController : Controller
    {
        private IActorDAO actorDAO;

        public ActorsController(IActorDAO actorDAO)
        {
            this.actorDAO = actorDAO;
        }
        
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(ActorVM vm)
        {
           if(vm.Request !=null)
            {
                vm.actors = actorDAO.FindActors(vm.Request);
            }
            return View(vm);
        }
    }
}