using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
