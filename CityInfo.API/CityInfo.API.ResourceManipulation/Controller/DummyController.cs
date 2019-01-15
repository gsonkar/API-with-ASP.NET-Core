using CityInfo.API.ResourceManipulation.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.ResourceManipulation.Controller
{
    public class DummyController:Microsoft.AspNetCore.Mvc.Controller
    {
        private CityInfoContext _ctx;

        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
