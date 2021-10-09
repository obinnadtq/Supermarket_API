using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Data.UnitOfWork;
using Supermarket.Model;

namespace Supermarket.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryUnitOfWork _categoryUnitOfWork;

        public CategoryService(ICategoryUnitOfWork categoryUnitOfWork)
        {
            _categoryUnitOfWork = categoryUnitOfWork;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryUnitOfWork.GetCategoriesAsync();
        }
    }
}
