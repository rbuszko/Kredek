using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RomanBuszkoLab6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Threading.Tasks;

namespace RomanBuszkoLab6.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Samochody do wyświetlenia
        /// </summary>
        List<CarViewModel> allCars;

        public HomeController()
        {
            this.allCars = new List<CarViewModel>();
            allCars.Add(new CarViewModel("Focus", "Ford", 72000, "~/focus.png"));
            allCars.Add(new CarViewModel("Golf", "Volkswagen", 80000, "~/golf.png"));
            allCars.Add(new CarViewModel("Civic", "Honda", 82000, "~/civic.png"));
            allCars.Add(new CarViewModel("Megene", "Renault", 67000, "~/megane.png"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InterestingLinks()
        {
            return View();
        }

        public IActionResult GetAllCars()
        {
            return View(this.allCars);
        }

        public IActionResult GetListOfModels()
        {
            List<string> allModels = new List<string>();
            foreach(var car in allCars)
            {
                allModels.Add(car.Model);
            }
            return View(allModels);
        }

        public IActionResult GetCarByModel(string selectedModel)
        {
            var car = allCars.Where(a => a.Model.ToLower() == selectedModel.ToLower()).FirstOrDefault();

            return View(car);
        }

        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;

            return View("ContactFormGreetings");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
