using PersonalFinance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Core.Repositories
{
    public interface ICategoryRepository : IRepository
    {
        Task AddAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync(string userId);
        Task<Category> GetAsync(int categoryId);
        Task DeleteAsync(Category category);
        Task UpdateAsync(Category category);
    }
}
