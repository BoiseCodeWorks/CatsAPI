using System;
using System.Collections.Generic;
using catsApi.Models;
using catsApi.DB;
using Microsoft.AspNetCore.Mvc;
using catsApi.Services;

namespace catsApi.Controllers
{
    [ApiController]  //NOTE Notifies compiler this is to be registered as a controller
    [Route("api/[controller]")] //NOTE RoutePath "WeatherForecast"
    public class CatsController : ControllerBase
    {
        private readonly CatsService _cs;
        public CatsController(CatsService cs) //DEPENDENCY INJECTION
        {
            _cs = cs;
        }

        [HttpGet] //NOTE this route is 'api/cats'
        public ActionResult<IEnumerable<Cat>> GetAll()
        {
            try
            {
                return Ok(_cs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{catId}")] //NOTE this route is 'api/cats/:id'
        public ActionResult<Cat> Get(string catId)
        {
            try
            {
                return Ok(_cs.GetById(catId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public ActionResult<Cat> Create([FromBody] Cat newCat) //NOTE "From the body, create a cat called newCat")
        {
            try
            {
                return Ok(_cs.Create(newCat));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
