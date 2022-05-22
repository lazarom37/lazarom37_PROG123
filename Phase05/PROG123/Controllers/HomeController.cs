using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PROG123.DAL;
using PROG123.Models;
using PROG123.utils;

namespace PROG123.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // this is for testing purpuse only.
            DatabaseHelper dbh = new DatabaseHelper(_configuration);
            ConnStatusModel status = dbh.GetConnectionStringAndConnectionStatus();
            ViewBag.ConnStr = status.ConnStr;
            ViewBag.DBStatus = status.DBConnectionStatus;
            ViewBag.Exception = status.Exception;
            return View();
        }

        // add your actions here 

        public IActionResult Page2(PersonModel pm)
        {
            //Creating a viewbag
            ViewBag.Something = "Created by Marcus Lazaro (Phase05)";

            DALPerson dp = new DALPerson(_configuration);
            string uID = dp.AddPerson(pm);
            pm.PersonID = uID;
            HttpContext.Session.SetString("uID", uID.ToString()); //Write to the session
            string strUID = HttpContext.Session.GetString("uID"); //Reads from the session

            //PersonModel
            return View(pm);
        }

        public IActionResult Edit(PersonModel pm)
        {
            string uID = HttpContext.Session.GetString("uID");
            DALPerson dp = new DALPerson(_configuration);
            PersonModel person = dp.getPerson(uID);

            return View(person);
        }

        public IActionResult UpdatePersonTable(PersonModel pm)
        {
            string uID = HttpContext.Session.GetString("uID");
            pm.PersonID = uID;
            DALPerson dp = new DALPerson(_configuration);
            dp.UpdatePerson(pm);

            return View("page2", pm);
        }

        public IActionResult Delete()
        {
            string uID = HttpContext.Session.GetString("uID");
            DALPerson dp = new DALPerson(_configuration);
            PersonModel pm = dp.getPerson(uID);
            dp.DeletePerson(uID);

            return View(pm);
        }
    }
}