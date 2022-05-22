using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PROG123.DAL;
using PROG123.Controllers;
using PROG123.Models;

namespace PROG123.Controllers
{
    public class LazaroController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public LazaroController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogIn(LogInCredentialsModel logInCredentialsModel)
        {
            DALPerson dp = new DALPerson(_configuration);
            PersonModel person = dp.CheckLogInCredentials(logInCredentialsModel);
            if (person == null)
            {
                ViewBag.LoginMessage = "login failed :(";
            }
            else
            {
                ViewBag.UserFirstName = person.FName;
                ViewBag.LoginMessage = null;
            }
            return View("Index");
        }
    }
}