using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using AzureRewards.Models;
using System.Threading.Tasks;
namespace AzureRewards.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Step1()
        {
            return View();
        }

        public IActionResult Step2()
        {
            return View();
        }
        public IActionResult Step3()
        {
            return View();
        }

  
    public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}