using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RTInsiderTourGuide.Models;
using Microsoft.EntityFrameworkCore;

namespace RTInsiderTourGuide.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            List<Tour> allTours = _context.Tours
                                    .Include( t => t.ImagesOfTour )
                                    .OrderByDescending( t => t.TourId )
                                    .ToList();
            return View(allTours);
        }

        [HttpGet("SearchTours")]
        public ViewResult Search()
        { 
            return View();
        }
        
        
        [HttpPost("SearchTours")]
        public IActionResult ProccessSearch(string keywords, string category, string dest, int days)
        { 
            List<Tour> results = _context.Tours
                                    .Include( t => t.ImagesOfTour )
                                    .Where(
                                        t => 
                                             keywords != "" && keywords != null? t.Title.Contains(keywords, StringComparison.InvariantCultureIgnoreCase) : true &&
                                             category != "Any"? t.Category.Contains(category) : true &&
                                             dest != "" && dest != null? t.Destination.Contains(dest, StringComparison.InvariantCultureIgnoreCase) : true &&
                                             days != 0 ? t.Duration == days : true
                                    )
                                    .ToList();
            return View("Search", results);
        }


        [HttpGet("UserDashboard")]
        public IActionResult UserDashboard()
        { 
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                User UserBookings = _context.Users
                                        .Include( u => u.UserBookings )
                                        .ThenInclude( ub => ub.TourOfTheBooking )
                                        .ThenInclude( t => t.ImagesOfTour )
                                        .FirstOrDefault( u => u.UserId == logUsr);

                return View("UserDashboard", UserBookings);
            }
            else
            {
                return RedirectToAction("Login", "User");
            }

        }


        [HttpGet("delete/booking/{bookingId}")]
        public IActionResult DeleteBooking(int bookingId)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                Booking bookingToDelete = _context.Bookings.FirstOrDefault( b => b.BookingId == bookingId);
                _context.Remove(bookingToDelete);
                _context.SaveChanges();

                return RedirectToAction("UserDashboard");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("tour/{tourId}")]
        public ViewResult TourDetails(int tourId)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");

            ViewBag.selectedTour = _context.Tours
                                    .Include( t => t.ImagesOfTour )
                                    .Include( t => t.TourActivities )
                                    .FirstOrDefault( t => t.TourId == tourId);
            if (logUsr != null)
            {
                ViewBag.IsBooked = _context.Users
                                    .Include( u => u.UserBookings )
                                    .FirstOrDefault( u => u.UserId == (int)logUsr && u.UserBookings.Any( b => b.TourId == tourId));
            }
            

            return View();
        }


        [HttpPost("/tour/topayment")]
        public IActionResult ToPayment(Booking newBooking)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                if (ModelState.IsValid)
                {
                    newBooking.UserId = (int)logUsr;
                    return RedirectToAction("Payment", newBooking);
                }
                else
                {
                    ViewBag.selectedTour = _context.Tours
                                    .Include( t => t.ImagesOfTour )
                                    .Include( t => t.TourActivities )
                                    .FirstOrDefault( t => t.TourId == newBooking.TourId);

                    return View("TourDetails");
                }
            }
            else
            {
                TempData["BookErr"] = true;
                return RedirectToAction("Register", "User");
            }
        }


        [HttpGet("payment")]
        public IActionResult Payment(Booking newBooking)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");

            Tour selectedTour = _context.Tours
                                    .Include( t => t.ImagesOfTour )
                                    .Include( t => t.TourActivities )
                                    .FirstOrDefault( t => t.TourId == newBooking.TourId);

            
            if (logUsr != null)
            {
                ViewBag.TotalPrice = (newBooking.NumberOfAdults * selectedTour.Price) + (newBooking.NumberOfChildern * (selectedTour.Price/2));
                ViewBag.selectedTour = selectedTour;
                return View(newBooking);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }


        [HttpGet("payment/confirmed")]
        public IActionResult Confirmed(Booking newBooking)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            
            if (logUsr != null)
            {
                _context.Bookings.Add(newBooking);
                _context.SaveChanges();
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }






        
    }
}
