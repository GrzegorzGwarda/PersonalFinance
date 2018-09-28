using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PersonalFinance.Core.Domain;
using PersonalFinance.Core.Repositories;
using PersonalFinance.Infrastructure.DTO;

namespace PersonalFinance.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateAsync(Category category)
            => await _categoryRepository.AddAsync(category);

        public async Task DeleteAsync(int categoryId)
        {
            Category category = await _categoryRepository.GetAsync(categoryId);
            await _categoryRepository.DeleteAsync(category);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoryAsync(string userId)
        { 
            var category = await _categoryRepository.GetAllAsync(userId);
            return _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(category);
        }
    }
}
