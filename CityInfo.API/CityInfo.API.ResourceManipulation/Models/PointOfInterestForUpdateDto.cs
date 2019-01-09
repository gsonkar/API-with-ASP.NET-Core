﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.ResourceManipulation.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}