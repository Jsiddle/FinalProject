using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesRepository _repo;
        public SalesController(ISalesRepository repo)
        {
            _repo = repo;
        }



        public IActionResult Index()
        {
            var sales = _repo.GetAllSales();
            
            return View(sales);
        }

        public IActionResult ViewSales(int id)
        {
            var sales = _repo.GetSales(id);

            return View(sales);
        }

    }
}
