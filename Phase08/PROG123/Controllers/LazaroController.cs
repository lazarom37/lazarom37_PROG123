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

                string uID = person.PersonID;
                HttpContext.Session.SetString("uID", uID.ToString());
            }
            return View("Index");
        }
        public IActionResult EnterNewProduct()
        {
            string strUID = HttpContext.Session.GetString("uID");

            if (strUID == null)
            {
                ViewBag.LoginMessage = "please login first :(";
                return View("Index");
            }

            return View();
        }

        public IActionResult AddProductToDB(ProductModel pm)
        {
            string strUID = HttpContext.Session.GetString("uID");
            if (strUID == null)
            {
                ViewBag.LoginMessage = "please login first :(";
                return View("Index");
            }
            else
            {
                DALProducts dp = new DALProducts(_configuration);
                string PID = dp.AddNewProduc(pm);

                @ViewBag.itemName = pm.Name;
                @ViewBag.itemDesc = pm.Description;
                @ViewBag.itemPrice = pm.Price;
                @ViewBag.itemInv = pm.InventoryAmount;

                //set productID on pm
            }

            return View();
        }

        public IActionResult ListAllProducts()
        {
            string strUID = HttpContext.Session.GetString("uID");
            if (strUID == null)
            {
                ViewBag.LoginMessage = "please login first :(";
                return View("Index");
            }
            else
            {
                DALProducts pm = new DALProducts(_configuration);
                LinkedList<ProductModel> allProds = pm.GetAllProducts();
                return View("ListAllProducts", allProds);
            }
        }

        public IActionResult OneClickBuy (string PID)
        {
            string strUID = HttpContext.Session.GetString("uID");
            if (strUID == null)
            {
                ViewBag.LoginMessage = "please login first :(";
                return View("Index");
            }
            else
            {
                DALSalesTransaction transaction = new DALSalesTransaction(_configuration);
                //call OneClickBuy method, returns a purchaseModel that will be returned to view
                return View("OneClickBuy", transaction.OneClickBuy(PID, strUID, 1));
            }
        }
    }
}