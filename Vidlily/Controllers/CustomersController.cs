using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidlily.Models;

namespace Vidlily.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> Customers = new List<Customer>()
        {
            new Customer() { Name = "Anny", Id = 1 },
            new Customer() { Name = "Joan", Id = 2 },
            new Customer() { Name = "Alex", Id = 3 }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);

            if (customer != null)
                return View(customer);
            return new HttpNotFoundResult();
        }
    }
}