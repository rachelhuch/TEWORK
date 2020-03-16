using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldLib.DAL;

namespace WorldAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public  CitiesController(ICityDAO cityDAO)
        {
            private ICityDAO=CityDAO;


        }
        // /api/cities--get all cities

            [HttpGet]
        public IActionResult GetCities()
        {

        }

        // /api/cities?countrycode=USA&district=ohio --get filtered cities

        // /api/cities/3 --get a city by it's id (i.e. 3)


    }
}