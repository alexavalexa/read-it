﻿using Microsoft.AspNetCore.Mvc;
using ReadIt.Models;
using ReadIt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadIt.Controllers
{
    public class BookController : Controller
    {
        private BookService bookService;
        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            List<Book> books = bookService.GetAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string title, string author)
        {
            bookService.Add(title, author);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Book book = BookService.GetById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, string title, string author)
        {
            bookService.Edit(id, title,author);
            return RedirectToAction(nameof(Index));
        }

    }
}
