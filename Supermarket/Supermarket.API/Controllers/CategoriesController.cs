using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.DTOs;
using Supermarket.Model;
using Supermarket.Services;

namespace Supermarket.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> GetCategory()
        {
            var categories =  await _categoryService.GetCategoriesAsync();

            var dto = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(categories);

            return dto;
        }
    }
}
