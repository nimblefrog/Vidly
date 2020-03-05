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
            var customers = new List<Customer> {
                new Customer { Name = "John Smith", Id=1},
                new Customer { Name = "Mary Williams", Id=2}
            };

            var viewModel = new RandomMovieModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if(id == 1)
            {
                return Content("John Smith");
            }
            else if (id == 2)
            {
                return Content("Mary Williams");
            }
            return View();
        }
    }
}