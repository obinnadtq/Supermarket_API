using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Supermarket.Model;

namespace Supermarket.Data.Models
{
    public class Category_DAL
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
