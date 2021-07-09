using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Categories
    {
        public Categories()
        {

        }

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
    }
}
