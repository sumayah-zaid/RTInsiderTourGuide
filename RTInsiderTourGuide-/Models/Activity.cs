using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace RTInsiderTourGuide.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }

        [Required]
        public string TourActivity { get; set; }

        [Required]
        public string TourActivityDescription { get; set; }

        public int TourId { get; set; }

        public Tour TourOfActivity { get; set; }
    }
}