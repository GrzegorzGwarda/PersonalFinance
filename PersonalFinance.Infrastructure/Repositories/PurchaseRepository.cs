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
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly FinanceContext _financeContext;

        public PurchaseRepository(FinanceContext financeContext)
        {
            _financeContext = financeContext;
        }

        public async Task AddAsync(Purchase purchase)
        {
            _financeContext.Purchases.Add(purchase);
            await _financeContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Purchase purchase)
        {
            _financeContext.Purchases.Remove(purchase);
            await _financeContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Purchase>> GetAllAsync(string userId)
            => await _financeContext.Purchases.Where(x => x.userId == userId).ToListAsync();

        public async Task<IEnumerable<Purchase>> GetAllAsync(string userId, int categoryId)
            => await _financeContext.Purchases.Where(x => x.User.Id == userId && x.categoryId == categoryId).ToListAsync();

        public async Task<Purchase> GetAsync(int purchaseId)
            => await _financeContext.Purchases.Where(x => x.purchaseId == purchaseId).SingleOrDefaultAsync();

        public async Task UpdateAsync(Purchase purchase)
        {
            _financeContext.Entry(purchase).State = EntityState.Modified;
            await _financeContext.SaveChangesAsync();
        }
    }
}
