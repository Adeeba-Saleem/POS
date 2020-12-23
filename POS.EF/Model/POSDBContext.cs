using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace POS.EF.Model
{
    public partial class POSDBContext : DbContext
    {
        public POSDBContext()
        {
        }

        public POSDBContext(DbContextOptions<POSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryTable> CategoryTables { get; set; }
        public virtual DbSet<ExpiryDetail> ExpiryDetails { get; set; }
        public virtual DbSet<ProductsDetailTable> ProductsDetailTables { get; set; }
        public virtual DbSet<StockMovementTable> StockMovementTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server =.; Database=POSDB; Trusted_connection=true; MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CategoryTable>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId);

                entity.ToTable("CategoryTable");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpiryDetail>(entity =>
            {
                entity.HasKey(e => e.ExpiryId);

                entity.Property(e => e.ExpiryId).ValueGeneratedNever();

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ManufactureDate).HasColumnType("date");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsDetailTable>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(13)
                    .IsFixedLength(true);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ValuationMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockMovementTable>(entity =>
            {
                entity.HasKey(e => e.StockMovementId);

                entity.ToTable("StockMovementTable");

                entity.Property(e => e.StockMovementId)
                    .ValueGeneratedNever()
                    .HasColumnName("StockMovementID");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.StockMovemntDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
