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

namespace RTInsiderTourGuide.Controllers
{
    public class UserController : Controller
    {
        private MyContext _context;

        public UserController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("register")]
        public ViewResult Register()
        {
            if (TempData["BookErr"] != null)
            {
                ViewBag.needAccount = "You must be logged in to book a tour";
            }
            return View();
        }

        [HttpPost("register")]
        public IActionResult RegisterForm(User user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(i => i.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in Use! Try Another one");
                    return View("Register");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);

                    
                    _context.Users.Add(user);
                    _context.SaveChanges();

                    if (user.UserId == 1)
                    {
                        User regUsr = _context.Users.FirstOrDefault( u => u.UserId == user.UserId );
                        regUsr.IsAdmin = true;
                        _context.SaveChanges();
                    }                    
                    
                    HttpContext.Session.SetInt32("userId", user.UserId); // add seesion
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet("login")]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult LoginForm(LoginUser log_in)
        {
            if(ModelState.IsValid)
            {
                User db_user = _context.Users.FirstOrDefault(i => i.Email == log_in.LoginEmail);
                if(db_user == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Login!");
                    return View("Login");
                }
                else
                {
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(log_in, db_user.Password, log_in.LoginPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LoginEmail", "Invalid Login!");
                        return View("Login");
                    }
                    else
                    {
                    HttpContext.Session.SetInt32("userId", db_user.UserId); // add session
                    return RedirectToAction("Index", "Home");
                    }
            }    }
            else
            { 
                return View("Login");
            }
        }


        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
