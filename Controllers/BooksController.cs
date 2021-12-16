using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class BooksController : Controller
    {
        private readonly IBooksService _service;

        public BooksController(IBooksService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var AllBooks = await _service.GetAllAsync();
            return View(AllBooks);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allBooks.Where(n => n.Name.Contains(searchString) || n.About.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var bookDetail = await _service.GetBookByIdAsync(id);
            return View(bookDetail);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewBookDropdownsValues();
            ViewBag.Publishers = new SelectList(movieDropdownsData.Publishers, "Id", "Name");
            ViewBag.Authors = new SelectList(movieDropdownsData.Authors, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewBookDropdownsValues();
                ViewBag.Publishers = new SelectList(movieDropdownsData.Publishers, "Id", "Name");
                ViewBag.Authors = new SelectList(movieDropdownsData.Authors, "Id", "Name");

                return View(movie);
            }

            await _service.AddNewBookAsync(movie);
            return RedirectToAction(nameof(Index));
        }


        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var bookDetails = await _service.GetBookByIdAsync(id);
            if (bookDetails == null) return View("NotFound");

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Name = bookDetails.Name,
                About = bookDetails.About,
                Price = bookDetails.Price,
                CoverURL = bookDetails.CoverURL,
                BookGenre = bookDetails.Genre,
                PublisherId = bookDetails.PublisherID,
                AuthorIds = bookDetails.Authors.Select(n => n.AuthorID).ToList(),
            };

            var movieDropdownsData = await _service.GetNewBookDropdownsValues();
            ViewBag.Publishers = new SelectList(movieDropdownsData.Publishers, "Id", "Name");
            ViewBag.Authors = new SelectList(movieDropdownsData.Authors, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewBookVM book)
        {
            if (id != book.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var bookDropdownsData = await _service.GetNewBookDropdownsValues();
                ViewBag.Publishers = new SelectList(bookDropdownsData.Publishers, "Id", "Name");
                ViewBag.Authors = new SelectList(bookDropdownsData.Authors, "Id", "Name");

                return View(book);
            }

            await _service.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

    }
}
