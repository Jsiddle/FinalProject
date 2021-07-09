using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface IReviewRepository
    {
        public IEnumerable<Reviews> GetAllReviews();
        public Reviews GetReviews(int id);
    }
}
