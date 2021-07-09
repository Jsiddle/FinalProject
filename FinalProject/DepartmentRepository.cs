using Dapper;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _conn;
        public DepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Departments> GetAllDepartments()
        {
            return _conn.Query<Departments>("SELECT * FROM DEPARTMENTS;");
        }

        public Departments GetDepartments(int id)
        {
            return _conn.QuerySingle<Departments>("SELECT * FROM Departments WHERE DepartmentID = @id",
                new { id = id });
        }


    }
}
