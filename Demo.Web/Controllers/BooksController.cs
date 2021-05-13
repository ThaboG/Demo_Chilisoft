using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksService = Demo.Service.Logic.BooksService;

namespace Demo.Web.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly BooksService booksService;

        public BooksController(BooksService booksService)
        {
            this.booksService = booksService;
        }

        public IActionResult Index()
        {
            var res = booksService.GetAll();
            return View(res);
        }

        public IActionResult New()
        {
            return View(new DAL.Entities.Books()
            {
                ID = Guid.NewGuid(),
                IsDeleted = false,
                CreateDateTime = DateTimeOffset.Now
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(DAL.Entities.Books books)
        {

            if (!ModelState.IsValid)
            {
                return View(books);
            }
            books.SyncClientID = Guid.NewGuid();
            books.SyncTime = DateTimeOffset.Now;
            var Res = booksService.Add(books);
            if (Res)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Not Added");
                return View(books);
            }
        }

        public IActionResult Edit(Guid id)
        {
            return View(booksService.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id,DAL.Entities.Books books)
        {

            if (!ModelState.IsValid)
            {
                return View(books);
            }

            books.ModifiedDate = DateTimeOffset.Now;
            books.SyncClientID = Guid.NewGuid();
            books.SyncTime = DateTimeOffset.Now;

            var Res = booksService.Update(books);
            if (Res)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Not Added");
                return View(books);
            }
        }


        public IActionResult Details(Guid id)
        {
            return View(booksService.Get(id));
        }


    }
}
