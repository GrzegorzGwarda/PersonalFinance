using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Infrastructure.DTO
{
    public class PurchaseDto
    {
        public int purchaseId { get; set; }
        public string ShopName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
