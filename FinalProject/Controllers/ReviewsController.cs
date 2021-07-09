using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewRepository _repo;

        public ReviewsController(IReviewRepository repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {
            var reviews = _repo.GetAllReviews();
            return View(reviews);
        }

        public IActionResult ViewReviews(int id)
        {
            var reviews = _repo.GetReviews(id);

            return View(reviews);
        }

    }
}
