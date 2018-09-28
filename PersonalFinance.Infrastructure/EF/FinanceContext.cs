using Microsoft.AspNet.Identity.EntityFramework;
using PersonalFinance.Core.Domain;
using PersonalFinance.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Infrastructure.EF
{
    public class FinanceContext : IdentityDbContext<ApplicationUser>
    {
        public FinanceContext() : base("PersonalFinanceConnection") { }

        public static FinanceContext Create()
        {
            return new FinanceContext();
        }
        public DbSet<Category> Categorys { get; set; }
        //public DbSet<User> User { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}