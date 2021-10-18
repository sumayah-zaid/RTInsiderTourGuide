using System.ComponentModel.DataAnnotations;
using System;

namespace RTInsiderTourGuide.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public int TourId { get; set; }

        public int NumberOfChildern { get; set; } = 0;

        [Required]
        public int NumberOfAdults { get; set; }

        public User UserOfTheBooking { get; set; }

        public Tour TourOfTheBooking { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}