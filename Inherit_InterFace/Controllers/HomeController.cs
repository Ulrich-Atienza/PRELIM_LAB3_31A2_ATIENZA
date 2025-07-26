using System.Diagnostics;
using Inherit_InterFace.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inherit_InterFace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { CustomerId = 1, FirstName = "Crocotium", MiddleName = "A.", LastName = "Augurnus", Birthday = new DateTime(1990, 1, 10) });
            customers.Add(new Customer { CustomerId = 2, FirstName = "Robertus", MiddleName = "B.", LastName = "Apollonarius", Birthday = new DateTime(1985, 5, 23) });
            customers.Add(new Customer { CustomerId = 3, FirstName = "Pleusicles ", MiddleName = "C.", LastName = "Vindex", Birthday = new DateTime(1992, 12, 3) });
            customers.Add(new VipCustomer { CustomerId = 6, FirstName = "Turbalio", MiddleName = "F.", LastName = "Pictor", Birthday = new DateTime(1980, 7, 7) });
            customers.Add(new VipCustomer { CustomerId = 6, FirstName = "Petrus", MiddleName = "F.", LastName = "Sartorius", Birthday = new DateTime(1980, 7, 7) });
            customers.Add(new VipCustomer { CustomerId = 6, FirstName = "Antipho", MiddleName = "F.", LastName = "Tyrannus", Birthday = new DateTime(1988, 1, 12) });

            return View(customers);

        }
    }
}
