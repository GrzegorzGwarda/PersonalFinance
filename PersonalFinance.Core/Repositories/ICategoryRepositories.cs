using PersonalFinance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Core.Repositories
{
    public interface ICategoryRepositories
    {
        Task AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> GetAllCategory(string userId);
        Task RemoveAsync(Category category);
        Task UpdateAsync(Category category);
    }
}
