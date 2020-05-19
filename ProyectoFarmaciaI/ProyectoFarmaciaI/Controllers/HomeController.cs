using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFarmaciaI.Models;
using ProyectoFarmaciaI.Controllers;



namespace ProyectoFarmaciaI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (ViewData["User"] == "")
            {
                Response.Redirect("Home/index");
            }
            else
            {
                Response.Redirect("Login/Login");

            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
