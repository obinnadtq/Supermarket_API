using System;
using Microsoft.EntityFrameworkCore;
using Supermarket.Data.Models;
using Supermarket.Model;

namespace Supermarket.Data.Persistence.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
