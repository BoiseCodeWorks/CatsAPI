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
    public class DogsController : ControllerBase
    {
        private readonly DogsService _ds;
        public DogsController(DogsService ds) //DEPENDENCY INJECTION
        {
            _ds = ds;
        }

        [HttpGet] //NOTE this route is 'api/dogs'
        public ActionResult<IEnumerable<Dog>> Get()
        {
            try
            {
                return Ok(_ds.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")] //NOTE this route is 'api/cats/:id'
        public ActionResult<Dog> Get(string id)
        {
            try
            {
                return Ok(_ds.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public ActionResult<Dog> Create([FromBody] Dog newDog) //NOTE "From the body, create a dog called newDog")
        {
            try
            {
                return Ok(_ds.Create(newDog));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Dog> Edit(string id, [FromBody] Dog update)
        {
            try
            {
                update.Id = id;
                return Ok(_ds.Edit(update));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(string id)
        {
            try
            {
                return Ok(_ds.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
