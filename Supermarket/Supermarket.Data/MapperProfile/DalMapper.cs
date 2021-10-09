using System;
using AutoMapper;
using Supermarket.Data.Models;
using Supermarket.Model;

namespace Supermarket.Data.MapperProfile
{
    public class DalMapper
    {
       public void CreateMap()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, Product_DAL>();
                cfg.CreateMap<Product_DAL, Product>();
                cfg.CreateMap<Category, Category_DAL>();
                cfg.CreateMap<Category_DAL, Category>();
            });
        }
    }
}
