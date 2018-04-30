using CarERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarERP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCustomer()
        {
            List<CustomerViewModel> customer = new List<CustomerViewModel>();

            customer.Add(new CustomerViewModel { first_name="Dorje", last_name="Sherpa", address="123 st. 123 cty, 111 state", email="123@gmail.com", phone=1111111111});
            customer.Sort();
            return View(customer);
        }
    }
}