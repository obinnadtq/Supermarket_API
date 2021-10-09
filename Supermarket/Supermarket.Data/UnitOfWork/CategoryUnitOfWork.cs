using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Data.Repository;
using Supermarket.Model;

namespace Supermarket.Data.UnitOfWork
{
    public class CategoryUnitOfWork : ICategoryUnitOfWork
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryUnitOfWork(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryRepository.GetCategoriesAsync();
        }
    }
}
