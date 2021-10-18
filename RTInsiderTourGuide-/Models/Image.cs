using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace RTInsiderTourGuide.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        public int TourId { get; set; }

        public Tour TourOfImage { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

    }

}