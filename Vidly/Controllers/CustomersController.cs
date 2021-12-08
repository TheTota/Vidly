using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        IEnumerable<Customer> customers = new List<Customer>
        {
            new Customer { Id = 0, Name = "James Harden" },
            new Customer { Id = 1, Name = "Armoni Brooks" }
        };

        public ActionResult Index()
        {
            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }  
    }
}