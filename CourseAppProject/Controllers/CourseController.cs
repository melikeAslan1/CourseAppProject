using CourseAppProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseAppProject.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "MVC Course";
            course.Description = "güzel bir kurs";
            course.IsPublished = true;

            return View(course);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        {
            return View();
        }
    }
}
