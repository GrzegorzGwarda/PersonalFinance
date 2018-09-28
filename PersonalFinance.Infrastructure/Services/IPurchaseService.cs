using PersonalFinance.Core.Domain;
using PersonalFinance.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Infrastructure.Services
{
    public interface IPurchaseService : IService
    {
        Task CreateAsync(Purchase purchase);
        Task<IEnumerable<PurchaseDto>> GetPurchaseByCategoryAsync(string userId, int categoryId);
        Task<IEnumerable<PurchaseDto>> GetAllPurchaseAsync(string userId);
        Task DeleteAsync(int purchaseId);
        Task UpdateAsync(int purchaseId);
    }
}
