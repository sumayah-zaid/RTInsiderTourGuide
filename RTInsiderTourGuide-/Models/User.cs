using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTInsiderTourGuide.Models
{
  public class User
  {
      [Key]
      public int UserId { get; set; }

      [Required]
      [MinLength(3, ErrorMessage = "Username must be at least 3 characters!")]
      [Display(Name = "Username: ")]
      public string Username { get; set; }

      [Required]
      [MinLength(2, ErrorMessage = "First name must be at least 2 characters!")]
      [Display(Name = "First Name: ")]
      public string FirstName { get; set; }

      [Required]
      [MinLength(2, ErrorMessage = "Last name must be at least 2 characters!")]
      [Display(Name = "Last Name: ")]
      public string LastName { get; set; }

      [Required]
      [EmailAddress]
      [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid email format!")]
      [Display(Name="Email: ")]
      public string Email { get; set; }

      [Required]
      [Display(Name="Phone: ")]
      [DataType(DataType.PhoneNumber)]
      public string Phone { get; set; }

      [Required]
      [Display(Name="Country: ")]
      public string Country { get; set; }

      [Required(ErrorMessage ="You must enter a birth date!")]
      [DataType(DataType.Date)]
      [Display(Name="Birth Date: ")]  
      [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}", ApplyFormatInEditMode=true)]
      public DateTime BirthDate { get; set; }

      [Required]
      [DataType(DataType.Password)]
      [MinLength(8, ErrorMessage = "Password must be at least 8 characters!")]
      [Display(Name="Password: ")]
      public string Password { get; set; }

      public bool IsAdmin { get; set; } = false;

      public List<Booking> UserBookings { get; set; }

      public DateTime CreatedAt { get; set; } = DateTime.Now;
      public DateTime UpdatedAt { get; set; } = DateTime.Now;

      [NotMapped]
      [Compare("Password", ErrorMessage = "Passwords must match!")]
      [DataType(DataType.Password)]
      [Display(Name="Confirm Password: ")]
      public string Confirm { get; set; }
        
  }
}