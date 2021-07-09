using Dapper;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly IDbConnection _conn;

        public ReviewRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Reviews> GetAllReviews()
        {
            return _conn.Query<Reviews>("SELECT * FROM REVIEWS;");
        }

        public Reviews GetReviews(int id)
        {
            return _conn.QuerySingle<Reviews>("SELECT * FROM Reviews WHERE ReviewID = @id",
                new { id = id });
        }

    }
}
