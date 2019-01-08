using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controller
{
    [Route("api/cities")]
    public class CitiesController :Microsoft.AspNetCore.Mvc.Controller
    {
        //The action method should not static : http://www.tutorialsteacher.com/mvc/action-method-in-mvc

        //[HttpGet("api/cities")]
        //public JsonResult GetCities()
        //{
        //    return new JsonResult(new List<object>
        //    {
        //        new {id=1,name="New York City"},
        //        new {id=2,name="Boston"}
        //    });
        //}

        //Reading Values using Model
        
        public  IActionResult GetCitiesUsingModel()
        {
           var temp=new JsonResult(CitiesDataStore.Current.Cities);
            return Ok(temp);

        }

        [HttpGet("{id}")]

        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }
             return Ok(city);
            return new JsonResult(city);
        }
    }
}
