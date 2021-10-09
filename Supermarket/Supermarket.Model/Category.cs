using System;
using System.Collections.Generic;

namespace Supermarket.Model
{
    public class Category
    {
        public Category()
        {

        }

        public Category(int categoryId)
        {
            CategoryId = categoryId;
            Products = new List<Product>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
