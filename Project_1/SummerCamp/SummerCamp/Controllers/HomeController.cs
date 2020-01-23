using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SummerCamp.Models;

namespace SummerCamp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int m = DateTime.Now.Month;
            if (m < 6)
                ViewBag.Semester = "Spring";
            else if (m < 8)
                ViewBag.Semester = "Summer";
            else if (m >= 8)
                ViewBag.Semester = "Fall";
            return View("Index");
        }

        [HttpGet]
        public ViewResult SignupForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignupForm(StudentSignup student)
        {
            if (ModelState.IsValid)
            {
                StudentList.AddResponse(student);
                return View("Confirmation", student);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        public ViewResult RegistrationList()
        {
            return View(StudentList.Responses.Where(r => r.Signup == true));
        }
    }
}