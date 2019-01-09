using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.ResourceManipulation.Models
{
    public class PointOfInterestForCreationDto
    {
        //[Required]
        public string Name { get; set; }
        
        public string Description { get; set; }

    }
}
