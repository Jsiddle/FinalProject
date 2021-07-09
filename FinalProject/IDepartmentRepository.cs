using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Departments> GetAllDepartments();
        public Departments GetDepartments(int id);
    }
}
