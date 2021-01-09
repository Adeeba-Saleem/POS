using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using POS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.EF
{
   public class POSDBContext : DbContext
    {
        public POSDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BrandTable> BrandTables { get; set; }
        public DbSet<CategoryTable> CategoryTables { get; set; }
        public DbSet<ExpiryDetail> ExpiryDetails { get; set; }
        public DbSet<ProductsDetailTable> ProductDetailTables { get; set; }
        public DbSet<StockMovementTable> StockMovementTables { get; set; }
        public DbSet<PartyAddressTable> PartyAddressTables { get; set; }
        public DbSet <PartyTable> PartyTables { get; set; }
        public DbSet <PartyTypeTable> PartyTypeTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandTable>().HasKey(e => e.BrandId);
            modelBuilder.Entity<CategoryTable>().HasKey(e => e.ProductCategoryId);
            modelBuilder.Entity<ExpiryDetail>().HasKey(e => e.ExpiryId);
            modelBuilder.Entity<ProductsDetailTable>().HasKey(e => e.ProductId);
            modelBuilder.Entity<StockMovementTable>().HasKey(e => e.StockMovementId);
        }

    }
}
