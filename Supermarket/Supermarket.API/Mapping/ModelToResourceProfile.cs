using System;
using AutoMapper;
using Supermarket.API.DTOs;
using Supermarket.Model;

namespace Supermarket.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryDTO>();
        }
    }
}
