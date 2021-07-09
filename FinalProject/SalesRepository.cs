using Dapper;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class SalesRepository : ISalesRepository
    {
        private readonly IDbConnection _conn;

        public SalesRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Sales> GetAllSales()
        {
            return _conn.Query<Sales>("SELECT * FROM SALES;");
        }

        public Sales GetSales(int id)
        {
            return _conn.QuerySingle<Sales>("SELECT * FROM Sales WHERE SalesID = @id",
                new { id = id });
        }


    }
}
