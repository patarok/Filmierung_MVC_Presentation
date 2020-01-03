using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmierung.Models;

namespace Filmierung.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> moviesList = new List<Movie>();

        // GET: Movies
        public ActionResult Index()
        {
            return View(moviesList);
        }

        public ActionResult ListOnly()
        {
            return View(moviesList);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            var movieToShow = moviesList.Where(m => m.Id == id).FirstOrDefault();
            return View(movieToShow);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(Movie m)
        {
            try
            {
                // TODO: Add insert logic here
                // TODO: Add insert logic here
                m.Id = moviesList.Count + 1;
                m.Aktiv = true;

                moviesList.Add(m);
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            var movieToEdit = moviesList.Where(y => y.Id == id).FirstOrDefault();
            return View(movieToEdit);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movie m)
        {
            try
            {
                // TODO: Add update logic here
                var movieToEdit = moviesList.Where(y => y.Id == id).FirstOrDefault();
                moviesList.Remove(movieToEdit);
                moviesList.Add(m);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
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
