using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployee(int id);
        public void InsertEmployee(Employee employeeToInsert);
        public IEnumerable<Category> GetCategories();
        public Employee AssignCategory();

    }
}
