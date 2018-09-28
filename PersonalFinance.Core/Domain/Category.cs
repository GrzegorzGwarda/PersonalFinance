using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Core.Domain
{
    public class Category
    {
        public int categoryId { get; set; }
        public string Name { get; set; }

        public string userId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Category(){}

    }
}
