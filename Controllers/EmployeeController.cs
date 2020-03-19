using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.ViewModel;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employee;

        public EmployeeController(EmployeeService employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(EmployeeViewModel employeePost)
        {
            var emp = _employee.GetEmployee(employeePost.UserName);

            if (employeePost.Password != emp.Password)
            {
                return BadRequest("Wrong Password");
            }
            else
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim("EmployeeId", emp.Id.ToString()),
                    new Claim(ClaimTypes.Name, emp.UserName),
                    new Claim(ClaimTypes.SerialNumber, emp.Password),
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }

            return RedirectToRoute(new { controller = "Customer", action = "Index" });
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
