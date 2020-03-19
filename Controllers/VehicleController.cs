using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CarServiceManagementSystem.Controllers
{
    [Authorize]
    public class VehicleController : Controller
    {
        private readonly VehicleService _vehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public IActionResult Index(int customerId)
        {
            var vehicles = _vehicleService.GetVehicles(customerId);
            return View(vehicles);
        }

        [HttpGet]
        public IActionResult GetVehicle(int Id)
        {
            var vehicle = _vehicleService.GetVehicle(Id);
            return View(vehicle);
        }

        [HttpGet]
        public IActionResult InsertVehicle([FromQuery]int customerId)
        {

            VehicleViewModel newVehicle = new VehicleViewModel
            {
                CustomerId = customerId
            };
            return View(newVehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertVehicle(VehicleViewModel vehiclePost)
        {
            if (!ModelState.IsValid)
            {
                return View(vehiclePost);
            }
            _vehicleService.InsertVehicle(vehiclePost);
            return RedirectToRoute(new { controller = "Customer", action = "GetCustomer", Id = vehiclePost.CustomerId });
        }

        [HttpGet]
        public IActionResult UpdateVehicle(int Id)
        {
            VehicleViewModel vehicleView = _vehicleService.GetVehicleForUpdate(Id);

            return View(vehicleView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateVehicle(VehicleViewModel vehiclePost)
        {
            if (!ModelState.IsValid)
            {
                return View(vehiclePost);
            }
            _vehicleService.UpdateVehicle(vehiclePost);
            return RedirectToRoute(new { controller = "Vehicle", action = "GetVehicle", vehiclePost.Id });
        }

        [HttpGet]
        public IActionResult DeleteVehicle(int Id)
        {
            var vehicle = _vehicleService.GetVehicle(Id);
            return View(vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVehicle(VehicleViewModel vehiclePost)
        {
            _vehicleService.DeleteVehicle(vehiclePost);
            return RedirectToRoute(new { controller = "Customer", action = "Index" });
        }
    }
}
