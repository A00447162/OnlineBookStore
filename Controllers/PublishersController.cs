using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheOnlineBookStore.Data;
using TheOnlineBookStore.Data.Services;
using TheOnlineBookStore.Models;

namespace TheOnlineBookStore.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublishersService _service;

        public PublishersController(IPublishersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var AllPublishers = await _service.GetAllAsync();
            return View(AllPublishers);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,PictureURL,About")] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return View(publisher);
            }
            await _service.AddAsync(publisher);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);

            if (publisherDetails == null) return View("Empty");
            return View(publisherDetails);
        }

        //Get: Authors/Create
        public async Task<IActionResult> Edit(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PictureURL,About")] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return View(publisher);
            }
            await _service.UpdateAsync(id, publisher);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
