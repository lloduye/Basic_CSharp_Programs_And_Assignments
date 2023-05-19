﻿using StudentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - Academy of Learning";

            return View();
        }


        public ActionResult Instructor( int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> Instructors = new List<Instructor>
            {
                new Instructor
                {
                    id=1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    id=2,
                    FirstName = "Brett",
                    LastName = "Calender"
                },
                new Instructor
                {
                    id=3,
                    FirstName= "Adam",
                    LastName= "Smithsonian"
                }
            };

            return View(Instructors);
        }
    }
}