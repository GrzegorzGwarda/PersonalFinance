using PersonalFinance.Core.Domain;
using PersonalFinance.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Infrastructure.Services
{
    public interface ICategoryService : IService
    {
        Task CreateAsync(Category category);
        Task<IEnumerable<CategoryDto>> GetAllCategoryAsync(string userId);
        Task DeleteAsync(int categoryId);
    }
}
