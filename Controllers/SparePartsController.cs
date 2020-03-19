using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.ViewModels;
using System;
using System.IO;

namespace CarServiceManagementSystem.Controllers
{
    [Authorize]
    public class SparePartsController : Controller
    {
        private readonly SparePartsService _sparePartsService;

        public SparePartsController(SparePartsService sparePartsService)
        {
            _sparePartsService = sparePartsService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            var parts = _sparePartsService.GetParts(searchString);
            return View(parts);
        }

        [HttpGet]
        public IActionResult GetParts(int Id)
        {
            var part = _sparePartsService.GetPart(Id);
            if(part.SparePartImage != null)
            {
                string imageBase64Data = Convert.ToBase64String(part.SparePartImage);
                string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                ViewBag.ImageDataUrl = imageDataURL;
            }
            return View(part);
        }

        [HttpGet]
        public IActionResult InsertPart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertPart(SparePartsViewModel partPost)
        {
            foreach(var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                partPost.SparePartImage = ms.ToArray();
            }

            if (!ModelState.IsValid)
            {
                return View(partPost);
            }
            _sparePartsService.InsertPart(partPost);
            return View(partPost);
        }

        [HttpGet]
        public IActionResult UpdatePart(int Id)
        {
            var part = _sparePartsService.GetPart(Id);
            return View(part);
        }

        [HttpPost]
        public IActionResult UpdatePart(SparePartsViewModel partPost)
        {
            if(Request.Form.Files != null)
            {
                foreach (var file in Request.Form.Files)
                {
                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    partPost.SparePartImage = ms.ToArray();
                }
            }

            if (!ModelState.IsValid)
            {
                return View(partPost);
            }
            _sparePartsService.UpdatePart(partPost);
            return RedirectToRoute(new { controller = "SpareParts", action = "GetParts", partPost.Id });
        }

        [HttpGet]
        public IActionResult DeletePart(int Id)
        {
            var part = _sparePartsService.GetPart(Id);
            return View(part);
        }

        [HttpPost]
        public IActionResult DeletePart(SparePartsViewModel partPost)
        {
            _sparePartsService.DeletePart(partPost);
            return RedirectToAction(nameof(Index));
        }
    }
}
