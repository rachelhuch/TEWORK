using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAO customerDAO;

        public CustomersController(ICustomerDAO customerDAO)
        {
            this.customerDAO = customerDAO;
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
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        //    /// <returns></returns>
        //    public ActionResult SearchResult(Customer request)
        //    {

        //    request.customers = customerDAO.SearchForCustomers(Customer request);
        //        return View(request);
        //    }
        //}
    }
       
    }
