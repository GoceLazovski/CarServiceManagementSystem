using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.ViewModels;

namespace CarServiceManagementSystem.Controllers
{
    [Authorize]
    public class JobPartsController : Controller
    {
        private readonly JobPartService _jobPart;

        public JobPartsController(JobPartService jobPart)
        {
            _jobPart = jobPart;
        }

        [HttpGet]
        public IActionResult GetJobPart(int jobId, int partId)
        {
            JobPartsViewModel jobPartsView = _jobPart.GetJobPart(jobId, partId);

            return View(jobPartsView);
        }

        [HttpGet]
        public IActionResult InsertJobPart([FromQuery]int jobId)
        {
            JobPartsViewModel newJobPart = _jobPart.InsertJobPartView(jobId);

            return View(newJobPart);
        }

        [HttpPost]
        public IActionResult InsertJobPart(JobPartsViewModel jobPart)
        {
            if (!ModelState.IsValid)
            {
                return View(jobPart);
            }

            _jobPart.InsertJobPart(jobPart);
            return RedirectToRoute(new { controller = "JobCard", action = "GetJobCard", Id = jobPart.JobCardId });
        }

        [HttpGet]
        public IActionResult UpdateJobPart([FromQuery]int jobId, int partId)
        {
            JobPartsViewModel jobPart = _jobPart.GetJobPart(jobId, partId);

            return View(jobPart);
        }

        [HttpPost]
        public IActionResult UpdateJobPart(JobPartsViewModel jobPartPost)
        {
            if (!ModelState.IsValid)
            {
                return View(jobPartPost);
            }
            _jobPart.UpdateJobPart(jobPartPost);
            return RedirectToRoute(new { controller = "JobCard", action = "GetJobCard", Id = jobPartPost.JobCardId });
        }
    }
}
