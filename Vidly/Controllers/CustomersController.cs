using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(x => x.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> {
                new Customer { Name = "John Smith", Id=1},
                new Customer { Name = "Mary Williams", Id=2}
            };
        }
    }
}