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
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IMapper _mapper;

        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public async Task CreateAsync(Purchase purchase)
            => await _purchaseRepository.AddAsync(purchase);

        public async Task DeleteAsync(int purchaseId)
        {
            Purchase purchase = await _purchaseRepository.GetAsync(purchaseId);
            await _purchaseRepository.DeleteAsync(purchase);
        }

        public async Task<IEnumerable<PurchaseDto>> GetAllPurchaseAsync(string userId)
        {
            var purchase = await _purchaseRepository.GetAllAsync(userId);
            return _mapper.Map<IEnumerable<Purchase>, IEnumerable<PurchaseDto>>(purchase);
        }

        public async Task<IEnumerable<PurchaseDto>> GetPurchaseByCategoryAsync(string userId, int categoryId)
        {
            var purchase = await _purchaseRepository.GetAllAsync(userId, categoryId);
            return _mapper.Map<IEnumerable<Purchase>, IEnumerable<PurchaseDto>>(purchase);
        }

        public async Task UpdateAsync(int purchaseId)
        {
            Purchase purchase = await _purchaseRepository.GetAsync(purchaseId);
            await _purchaseRepository.UpdateAsync(purchase);
        }
    }
}
