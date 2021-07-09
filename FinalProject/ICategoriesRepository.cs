using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface ICategoriesRepository
    {
        public IEnumerable<Categories> GetAllCategories();
        public Categories GetCategories(int id);
    }
}
