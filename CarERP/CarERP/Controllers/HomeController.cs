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

            var model = new AddCustomerViewModel()
            {
                first_name = "Dorje",
                last_name = "Sherpa",
                phone = 6171111111,
                address = "1000 Loring ave., Salem, MA 00000",
                email = "d_sherpa@salemstate.edu",
                id = 0309438,

            };
            return View(model);
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