using Dapper;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly IDbConnection _conn;

        public CategoriesRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            return _conn.Query<Categories>("SELECT * FROM CATEGORIES;");
        }

        public Categories GetCategories(int id)
        {
            return _conn.QuerySingle<Categories>("SELECT * FROM Categories WHERE CategoryID = @id",
                new { id = id });
        }

    }
}
