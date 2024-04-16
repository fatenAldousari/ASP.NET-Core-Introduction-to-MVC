using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CivilId = 123, Name = "faten", Phone = 1234 }
            };
            return View(customers); 
        }
    }
}
