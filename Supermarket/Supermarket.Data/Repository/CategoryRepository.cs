using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Supermarket.Data.Persistence.Contexts;
using Supermarket.Model;

namespace Supermarket.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {

            var categories = await _db.Categories.ToListAsync();

            return categories;
        }
    }
}
