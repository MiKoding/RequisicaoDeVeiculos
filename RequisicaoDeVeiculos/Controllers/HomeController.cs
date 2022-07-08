using Microsoft.AspNetCore.Mvc;
using RequisicaoDeVeiculos.Models;
using System.Diagnostics;
//using System;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Data.Entity.Validation;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Net.Mail;
//using System.Configuration;
//using System.Data.Entity.Migrations;


namespace RequisicaoDeVeiculos.Controllers
{
   
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            
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