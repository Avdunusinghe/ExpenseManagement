using ExpenseManagement.Data.Configurations;
using ExpenseManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Data.Data
{
    public class ExpenseManagementDbContext : DbContext
    {
        public ExpenseManagementDbContext(DbContextOptions<ExpenseManagementDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=LAPTOP-2576JIPH\\SQLEXPRESS;Database=ExpenseManagement;User Id=sa;Password=1qaz2wsx@;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
        }

        public DbSet<Item> Items { get; set; }
    }
}
