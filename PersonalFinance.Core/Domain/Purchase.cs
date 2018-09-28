using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Core.Domain
{
    public class Purchase
    {
        public int purchaseId { get; set; }

        public string userId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int categoryId { get; set; }
        public virtual Category Category { get; set; }

        public string ShopName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Purchase(){}

    }
}
