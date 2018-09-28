using PersonalFinance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Core.Repositories
{
    public interface IPurchaseRepository
    {
        Task AddAsync(Purchase purchase);
        Task<Purchase> GetAsync(int purchaseId);
        Task<IEnumerable<Purchase>> GetAllAsync(string userId);
        Task<IEnumerable<Purchase>> GetAllAsync(string userId, int categoryId);
        Task DeleteAsync(Purchase purchase);
        Task UpdateAsync(Purchase purchase);
    }
}
