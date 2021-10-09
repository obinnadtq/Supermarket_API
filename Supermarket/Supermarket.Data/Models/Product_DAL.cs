using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Supermarket.Model;

namespace Supermarket.Data.Models
{
    public class Product_DAL
    {
        [Key]
        public int ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
    }
}
