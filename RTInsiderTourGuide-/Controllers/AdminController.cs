using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using RTInsiderTourGuide.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace RTInsiderTourGuide.Controllers
{
    public class AdminController : Controller
    {
        private MyContext _context;
        private IWebHostEnvironment _env;

        public AdminController(MyContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet("Admin")]
        public IActionResult AdminDashboard()
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                 User user = _context.Users.FirstOrDefault( u => u.UserId == (int)logUsr);
                 if (user.IsAdmin)
                 {
                     List<Tour> allTours = _context.Tours
                                    .Include( t => t.ImagesOfTour )
                                    .ToList();
                    return View(allTours);
                 }
                 else
                 {
                     return RedirectToAction("Index", "Home");
                 }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("admin/newtour")]
        public IActionResult CreateNewTour()
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                 User user = _context.Users.FirstOrDefault( u => u.UserId == (int)logUsr);
                 if (user.IsAdmin)
                 {
                     return View();
                 }
                 else
                 {
                     return RedirectToAction("Index", "Home");
                 }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost("/admin/newtour/add")]
        public IActionResult AddNewTour(Tour newTour)
        {   
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                 User user = _context.Users.FirstOrDefault( u => u.UserId == (int)logUsr);
                 if (user.IsAdmin)
                 {
                    if (ModelState.IsValid && newTour.TourImages != null)
                    {
                        // File Upload
                        string folder = "uploads/";
                        newTour.ImagesOfTour = new List<Image>();

                        foreach (IFormFile img in newTour.TourImages)
                        { 
                            Image image = new Image()
                            {
                                Name = img.FileName,
                                Url = UploadImages(folder, img),
                                TourId = newTour.TourId
                            };
                            
                            newTour.ImagesOfTour.Add(image);
                        }

                        //Add Activities
                        foreach (Models.Activity act in newTour.TourActivities)
                        {
                            act.TourId = newTour.TourId;
                        }

                        //Add to db
                        _context.Tours.Add(newTour);
                        _context.SaveChanges();

                        return RedirectToAction("CreateNewTour");
                        
                    }
                    else
                    {
                        return View("CreateNewTour");
                    } 
                 }
                 else
                 {
                     return RedirectToAction("Index", "Home");
                 }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpGet("Admin/editTour/{id}")]
        public IActionResult EditTour(int id)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                 User user = _context.Users.FirstOrDefault( u => u.UserId == (int)logUsr);
                 if (user.IsAdmin)
                 {
                     Tour thisTour = _context.Tours.Include(t => t.TourActivities).FirstOrDefault(e => e.TourId == id);

                    return View("EditTour", thisTour);
                 }
                 else
                 {
                     return RedirectToAction("Index", "Home");
                 }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost("Admin/editTourProcess/{id}")]
        public IActionResult EditTourProcess(int id, Tour editedTour)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                User user = _context.Users.FirstOrDefault( u => u.UserId == (int)logUsr);
                if (user.IsAdmin)
                {
                    Tour thisTour = _context.Tours.Include( t => t.TourActivities ).Include(t => t.ImagesOfTour).FirstOrDefault(e => e.TourId == id);
                    if(ModelState.IsValid)
                    {
                        thisTour.Title = editedTour.Title;
                        thisTour.Destination = editedTour.Destination;
                        thisTour.Duration = editedTour.Duration;
                        thisTour.Category = editedTour.Category;
                        thisTour.Price = editedTour.Price;
                        thisTour.Date = editedTour.Date;
                        thisTour.TourActivities = editedTour.TourActivities;

                        // Update Images
                        if (editedTour.TourImages != null)
                        {
                            string folder = "Uploads/";
                            editedTour.ImagesOfTour = new List<Image>();

                            foreach (Image img in thisTour.ImagesOfTour)
                            {
                                string path = _env.WebRootPath + img.Url;
                                System.IO.File.Delete(path);
                            }
                            

                            foreach (IFormFile img in editedTour.TourImages)
                            { 
                                Image image = new Image()
                                {
                                    Name = img.FileName,
                                    Url = UploadImages(folder, img),
                                    TourId = editedTour.TourId
                                };
                                
                                editedTour.ImagesOfTour.Add(image);
                            }
                            thisTour.ImagesOfTour = editedTour.ImagesOfTour;
                        }
                        
                        thisTour.UpdatedAt = DateTime.Now;
                        _context.SaveChanges();
                        return RedirectToAction("AdminDashboard");
                    }
                    else
                    {
                        return View("EditTour", thisTour);
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("admin/delete/{tourId}")]
        public IActionResult DeleteTour(int tourId)
        {
            int? logUsr = HttpContext.Session.GetInt32("userId");
            if (logUsr != null)
            {
                 User user = _context.Users.FirstOrDefault( u => u.UserId == (int)logUsr);
                 if (user.IsAdmin)
                 {
                     Tour tourToBeDeleted = _context.Tours.FirstOrDefault( t => t.TourId == tourId);

                     _context.Tours.Remove(tourToBeDeleted);
                     _context.SaveChanges();

                     return RedirectToAction("AdminDashboard");
                 }
                 else
                 {
                     return RedirectToAction("Index", "Home");
                 }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        private string UploadImages(string path, IFormFile file)
        {
            path += Guid.NewGuid().ToString()+"_"+file.FileName;

            string serverFolder = Path.Combine(_env.WebRootPath, path);

            file.CopyTo(new FileStream(serverFolder, FileMode.Create));

            return "/" + path;
        }



    }
}