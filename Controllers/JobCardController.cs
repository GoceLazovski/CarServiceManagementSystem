using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.ViewModels;
using System.Security.Claims;

namespace CarServiceManagementSystem.Controllers
{
    [Authorize]
    public class JobCardController : Controller
    {
        private readonly JobCardService _jobCardService;

        public JobCardController(JobCardService jobCardService)
        {
            _jobCardService = jobCardService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            var jobCards = _jobCardService.GetJobCard(searchString);
            return View(jobCards);
        }

        [HttpGet]
        public IActionResult GetJobCard(int Id)
        {
            JobCardViewModel jobCard = _jobCardService.GetJobCard(Id);
            jobCard.Employee.UserName = HttpContext.User.FindFirstValue(ClaimTypes.Name);
            return View(jobCard);
        }

        [HttpGet]
        public IActionResult InsertJob([FromQuery]int vehicleId)
        {
            JobCardViewModel newJob = new JobCardViewModel
            {
                VehicleId = vehicleId,
                EmployeeId = int.Parse(HttpContext.User.FindFirstValue("EmployeeId"))
            };
            return View(newJob);
        }

        [HttpPost]
        public IActionResult InsertJob(JobCardViewModel jobCardPost)
        {
            if (!ModelState.IsValid)
            {
                return View(jobCardPost);
            }
            _jobCardService.InsertjobCard(jobCardPost);
            return View(jobCardPost);
        }

        [HttpGet]
        public IActionResult UpdateJob(int Id)
        {
            var job = _jobCardService.GetJobCard(Id);
            return View(job);
        }

        [HttpPost]
        public IActionResult UpdateJob(JobCardViewModel jobCardPost)
        {
            if (!ModelState.IsValid)
            {
                return View(jobCardPost);
            }
            _jobCardService.UpdateJobCard(jobCardPost);
            return RedirectToRoute(new { controller = "JobCard", action = "GetJobCard", jobCardPost.Id });
        }

        [HttpGet]
        public IActionResult DeleteJob(int Id)
        {
            var job = _jobCardService.GetJobCard(Id);
            return View(job);
        }

        [HttpPost]
        public IActionResult DeleteJob(JobCardViewModel jobCardPost)
        {
            _jobCardService.DeleteJobCard(jobCardPost);
            return RedirectToRoute(new { controller = "Customer", action = "Index" });
        }
    }
}
