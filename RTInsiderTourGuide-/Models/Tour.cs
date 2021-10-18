using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace RTInsiderTourGuide.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string Category { get; set; }


        [Required]
        public double Price { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        [Required]
        [NotMapped]
        [Display(Name = "Images")]
        public IFormFileCollection TourImages { get; set; }

        public List<Image> ImagesOfTour { get; set; }

        public List<Activity> TourActivities { get; set; }

        public List<Booking> TourBookings { get; set; }

    }
}