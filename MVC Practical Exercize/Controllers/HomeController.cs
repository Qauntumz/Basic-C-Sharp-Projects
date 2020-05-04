using MVC_Practical_Exercize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practical_Exercize.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Signup(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool hadDui, int speedingTicket, bool fullCoverage  )
        {
            if (carYear < 0 || carYear > DateTime.Now.Year || speedingTicket< 0 || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || dateOfBirth > DateTime.Now)
            {
                return View("Error");
            }
            else
            {
                double total = 50;
                double age = DateTime.Now.Year - dateOfBirth.Year;
                if (age < 18)
                {
                    total += 100;
                }
                else if (age < 25)
                {
                    total += 25;
                }
                else if (age > 100)
                {
                    total += 25;
                }


                if (carYear < 2000)
                {
                    total += 25;
                }
                else if (carYear > 2015)
                {
                    total += 25;
                }



                if (carMake.ToLower() == "porsche")
                {
                    total += 25;
                }
                else if (carMake == "porsche" && carModel.ToLower() == "911 carrera")
                {
                    total += 50;
                }

                total += speedingTicket * 10;

                if (hadDui)
                {
                    total *= 1.25;
                }



                if (fullCoverage)
                {
                    total *= 1.5;
                }

                using (CarInsuranceEntities db = new CarInsuranceEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    signup.DateOfBirth = dateOfBirth;
                    signup.CarYear = carYear;
                    signup.CarMake = carMake;
                    signup.CarModel = carModel;
                    signup.HadDui = hadDui;
                    signup.SpeedingTicket = speedingTicket;
                    signup.FullCoverage = fullCoverage;
                    signup.Quote = Convert.ToDecimal(total);

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

                return View("Success", total);
            }
        }

        public ActionResult Success(double quote)
        {
            return View(quote);
        }
    }
}