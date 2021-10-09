using System;
namespace Supermarket.Model
{
    public class Product
    {
        public Product() : this(0)
        {

        }

        public Product(int productId)
        {
            ProductId = productId;     
        }
        public int ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;

            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
