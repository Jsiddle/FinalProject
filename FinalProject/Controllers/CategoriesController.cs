using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _repo;

        public CategoriesController(ICategoriesRepository repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {
            var categories = _repo.GetAllCategories();
            return View(categories);
        }

        public IActionResult ViewCategories(int id)
        {
            var categories = _repo.GetCategories(id);

            return View(categories);
        }

    }
}
