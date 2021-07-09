using Dapper;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbConnection _conn;

        public EmployeeRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _conn.Query<Employee>("SELECT * FROM EMPLOYEES;");
        }

        public Employee GetEmployee(int id)
        {
            return _conn.QuerySingle<Employee>("SELECT * FROM EMPLOYEES WHERE EmployeeID = @id",
                new { id = id });
        }

        public void InsertEmployee(Employee employeeToInsert)
        {
            _conn.Execute("INSERT INTO employees (EMPLOYEEID, FIRSTNAME, MIDDLEINITIAL, LASTNAME, EMAILADDRESS, PHONENUMBER, TITLE, DATEOFBIRTH) VALUES (@employeeID, @firstName, @middleInitial, @lastName, @emailAddress, @phoneNumber, @title, @dateOfBirth);",
                new { employeeID = employeeToInsert.EmployeeID, firstName = employeeToInsert.FirstName, middleInitial = employeeToInsert.MiddleInitial, lastName = employeeToInsert.LastName, emailAddress = employeeToInsert.EmailAddress, phoneNumber = employeeToInsert.PhoneNumber, title = employeeToInsert.Title, dateOfBirth = employeeToInsert.DateOfBirth });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public Employee AssignCategory()
        {
            var categoryList = GetCategories();
            var employee = new Employee();
            employee.Categories = categoryList;

            return employee;
        }








    }
}
