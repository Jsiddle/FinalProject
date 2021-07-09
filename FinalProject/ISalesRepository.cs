using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface ISalesRepository
    {
        public IEnumerable<Sales> GetAllSales();
        public Sales GetSales(int id);
    }
}
