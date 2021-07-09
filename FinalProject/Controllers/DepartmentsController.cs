using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class DepartmentsController : Controller
    {

        private readonly IDepartmentRepository _repo;

        public DepartmentsController(IDepartmentRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var departments = _repo.GetAllDepartments();
            return View(departments);
        }

        public IActionResult ViewDepartments(int id)
        {
            var departments = _repo.GetDepartments(id);

            return View(departments);
        }

    }
}
