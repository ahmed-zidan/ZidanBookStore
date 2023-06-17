using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZidanBookStore.Models.Domain;
using ZidanBookStore.Repo.Abstract;

namespace ZidanBookStore.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genre;
        public GenreController(IGenreService genre)
        {
            _genre = genre;
        }

        //get /Genre/
        public IActionResult Index()
        {
            return View(_genre.GetAll());
        }

        //get /Genre/Add
        public IActionResult Add()
        {
            return View();
        }

        //post /Genre/Add
        [HttpPost]
        public IActionResult Add(Genre genre)
        {
            if (ModelState.IsValid)
            {
                if (_genre.Add(genre))
                {
                    TempData["Success"] = "Success";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Failure"] = "Failure";
                    return View(genre);
                }
            }
            else
            {
                return View(genre);
            }
        }

        


    }
}
