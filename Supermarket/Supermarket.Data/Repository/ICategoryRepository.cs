using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Data.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
