using PersonalFinance.Core.Domain;
using PersonalFinance.Core.Repositories;
using PersonalFinance.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FinanceContext _financeContext;

        public CategoryRepository(FinanceContext financeContext)
        {
            _financeContext = financeContext;
        }

        public async Task AddAsync(Category category)
        {
            _financeContext.Categorys.Add(category);
            await _financeContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync(string userId)
            => await _financeContext.Categorys.Where(x => x.User.Id == userId).ToListAsync();

        public async Task<Category> GetAsync(int categoryId)
            => await _financeContext.Categorys.Where(x => x.categoryId == categoryId).SingleOrDefaultAsync();

        public async Task DeleteAsync(Category category)
        {
            _financeContext.Categorys.Remove(category);
            await _financeContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _financeContext.Entry(category).State = EntityState.Modified;
            await _financeContext.SaveChangesAsync();

        }
    }
}
