using ASP.NETMVCSwithLambdaExpressions.Context;
using ASP.NETMVCSwithLambdaExpressions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVCSwithLambdaExpressions.Controllers
{
    public class BookController : Controller
    {

        BookContext db = new BookContext();
        // GET: Book
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        public ActionResult ShowAfter1990()
        {
            var books = db.Books.Where(b => b.Published >= new DateTime(1990,1,1));
            return View(books);
        }

        public ActionResult ShowAfter2000()
        {
            var books = db.Books.Where(b => b.Published >= new DateTime(2000, 1, 1));
            return View(books);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
