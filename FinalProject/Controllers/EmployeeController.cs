using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var employee = _repo.GetAllEmployees();
            return View(employee);
        }

        public IActionResult ViewEmployee(int id)
        {
            var employee = _repo.GetEmployee(id);

            return View(employee);
        }

        public IActionResult UpdateEmployee(int id)
        {
            Employee emp = _repo.GetEmployee(id);

            if (emp == null)
            {
                return View("EmployeeNotFound");
            }

            return View(emp);
        }

        public IActionResult InsertProduct()
        {
            var emp = _repo.AssignCategory();

            return View(emp);
        }
        public IActionResult InsertEmployeeToDatabase(Employee employeeToInsert)
        {
            _repo.InsertEmployee(employeeToInsert);

            return RedirectToAction("Index");
        }





    }
}
