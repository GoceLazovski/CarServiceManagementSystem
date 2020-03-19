using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.ViewModels;

namespace CarServiceManagementSystem.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            var customers = _customerService.GetCustomers(searchString);
            return View(customers);
        }

        [HttpGet]
        public IActionResult GetCustomer(int Id)
        {
            CustomerViewModel customer = _customerService.GetCustomer(Id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult InsertCustomer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertCustomer(CustomerViewModel customerPost)
        {
            if (!ModelState.IsValid)
            {
                return Ok("Not valid input");
            }
            _customerService.InsertCustomer(customerPost);
            return RedirectToRoute(new { controller = "Customer", action = "Index" });
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int Id)
        {
            var customer = _customerService.GetCustomer(Id);
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCustomer(CustomerViewModel customerPost)
        {
            if (!ModelState.IsValid)
            {
                return View(customerPost);
            }
            _customerService.UpdateCustomer(customerPost);
            return RedirectToRoute(new { controller = "Customer", action = "GetCustomer", customerPost.Id });
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int Id)
        {
            var customer = _customerService.GetCustomer(Id);
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCustomer(CustomerViewModel customerPost)
        {
            _customerService.DeleteCustomer(customerPost);
            return RedirectToAction(nameof(Index));
        }
    }
}
