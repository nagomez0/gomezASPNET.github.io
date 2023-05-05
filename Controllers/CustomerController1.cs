using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Orders()
        {
            var customer = new CustomerViewModel
            {
                CustomerNumber = 111111,
                FirstName = "John",
                LastName = "Smith",
                Orders = new List<CustomerOrder>
                {
                    new CustomerOrder { OrderId = 1, OrderDate = DateTime.Today, Description = "Part 1", Total = 10.00m },
                    new CustomerOrder { OrderId = 2, OrderDate = DateTime.Today, Description = "Part 2", Total = 20.00m },
                    new CustomerOrder { OrderId = 3, OrderDate = DateTime.Today, Description = "Part 3", Total = 30.00m }
                }
            };
            return View(customer);
        }
    }
}
