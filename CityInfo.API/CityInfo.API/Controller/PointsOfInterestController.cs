using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controller
{
    [Route("api/cities")]
    public class PointsOfInterestController :Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{pointOfInterestId}")]
        public IActionResult GetPointsOfInterest(int cityId,int pointOfInterestId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointOfInterestId);
            if (pointOfInterest == null)
                return NotFound();

            return Ok(pointOfInterest);
        }
    }
}
