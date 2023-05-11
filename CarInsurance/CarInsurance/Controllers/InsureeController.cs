using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            List<Insuree> insurees = db.Insurees.Where(i => i.Quote > 0).ToList();
            return View(insurees);
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    decimal baseQuote = 50;

                    // Age calculation
                    int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                    if (insuree.DateOfBirth > DateTime.Now.AddYears(-age))
                        age--;

                    // Calculate monthly total based on age
                    if (age <= 18)
                        baseQuote += 100;
                    else if (age >= 19 && age <= 25)
                        baseQuote += 50;
                    else if (age >= 26)
                        baseQuote += 25;

                    // Car year calculation
                    if (insuree.CarYear < 2000)
                        baseQuote += 25;
                    else if (insuree.CarYear > 2015)
                        baseQuote += 25;

                    // Car make and model calculation
                    if (insuree.CarMake == "Porsche")
                    {
                        baseQuote += 25;
                        if (insuree.CarModel == "911 Carrera")
                            baseQuote += 25;
                    }

                    // Speeding ticket calculation
                    baseQuote += insuree.SpeedingTickets * 10;

                    // DUI calculation
                    if (insuree.DUI)
                        baseQuote *= 1.25m;

                    // Full coverage calculation
                    if (insuree.CoverageType)
                        baseQuote *= 1.5m;

                    // Update the Quote field in the database
                    insuree.Quote = baseQuote;

                    // Save changes to the database
                    db.Insurees.Add(insuree);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //ASP.NET MVC Entity Framework Assignment Part 4

        [HttpPost]
        public ActionResult Quote([Bind] Insuree insuree)
        {
            // start with base price of $50/month
            double monthlyTotal = 50;

            // add age adjustment
            var curentDay = DateTime.Now;
            var Age = curentDay.Year - insuree.DateOfBirth.Year;

            if (Age <= 18)
            {
                monthlyTotal += 100;
            }
            else if (Age >= 19 && Age <= 25)
            {
                monthlyTotal += 50;
            }
            else
            {
                monthlyTotal += 25;
            }

            // add car year adjustment
            if (insuree.CarYear < 2000)
            {
                monthlyTotal += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                monthlyTotal += 25;
            }

            // add car make adjustment
            if (insuree.CarMake == "Porsche")
            {
                monthlyTotal += 25;

                // add car model adjustment
                if (insuree.CarModel == "911 Carrera")
                {
                    monthlyTotal += 25;
                }
            }

            // add speeding ticket adjustment
            monthlyTotal += insuree.SpeedingTickets * 10;

            // add DUI adjustment
            if (insuree.DUI)
            {
                monthlyTotal *= 1.25;
            }

            // add coverage adjustment
            if (insuree.CoverageType == true)
            {
                monthlyTotal *= 1.5;
            }

            // return result
            return View(monthlyTotal);
        }
    }
}
