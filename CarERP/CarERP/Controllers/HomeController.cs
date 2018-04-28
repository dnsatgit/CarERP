using CarERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarERP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.product = "Customer";
    
            return View();
        }

        [HttpGet]
        public ActionResult addCustomer()
        {
            return View(new AddCustomerViewModel());
        }
        [HttpPost]
        public ActionResult addCustomer(AddCustomerViewModel model)
        {
            if (ModelState.IsValid)
                ViewBag.result = "Customer has been added sucessfully.";
            return View(new AddCustomerViewModel());
        }
    }
}