using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Data.UnitOfWork
{
    public interface ICategoryUnitOfWork
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
