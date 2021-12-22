using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DienMayXanh_Store.Models
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTS { get; set; }
        public virtual DbSet<BRAND> BRANDS { get; set; }
        public virtual DbSet<CARTITEM> CARTITEMS { get; set; }
        public virtual DbSet<CATEGORY> CATEGORIES { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public virtual DbSet<IESLIP> IESLIPS { get; set; }
        public virtual DbSet<IESLIPDETAIL> IESLIPDETAILS { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }
        public virtual DbSet<PRODUCTAVAILABLE> PRODUCTAVAILABLES { get; set; }
        public virtual DbSet<RECIEPT> RECIEPTS { get; set; }
        public virtual DbSet<STAFF> STAFFS { get; set; }
        public virtual DbSet<WAREHOUSE> WAREHOUSES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.Permission)
                .IsUnicode(false);

            modelBuilder.Entity<BRAND>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<BRAND>()
                .HasMany(e => e.PRODUCTs)
                .WithRequired(e => e.BRAND)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CARTITEM>()
                .Property(e => e.RecieptID)
                .IsUnicode(false);

            modelBuilder.Entity<CARTITEM>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<CARTITEM>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CARTITEM>()
                .Property(e => e.SubTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORY>()
                .HasMany(e => e.PRODUCTs)
                .WithRequired(e => e.CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .HasMany(e => e.RECIEPTs)
                .WithRequired(e => e.CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IESLIP>()
                .Property(e => e.IESlipID)
                .IsUnicode(false);

            modelBuilder.Entity<IESLIP>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IESLIP>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<IESLIP>()
                .Property(e => e.WarehouseID)
                .IsUnicode(false);

            modelBuilder.Entity<IESLIP>()
                .HasMany(e => e.IESLIPDETAILs)
                .WithRequired(e => e.IESLIP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IESLIPDETAIL>()
                .Property(e => e.IESlipID)
                .IsUnicode(false);

            modelBuilder.Entity<IESLIPDETAIL>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<IESLIPDETAIL>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.CARTITEMs)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.IESLIPDETAILs)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.PRODUCTAVAILABLEs)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTAVAILABLE>()
                .Property(e => e.WarehouseID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTAVAILABLE>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTAVAILABLE>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RECIEPT>()
                .Property(e => e.RecieptID)
                .IsUnicode(false);

            modelBuilder.Entity<RECIEPT>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<RECIEPT>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<RECIEPT>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RECIEPT>()
                .HasMany(e => e.CARTITEMs)
                .WithRequired(e => e.RECIEPT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STAFF>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<STAFF>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<STAFF>()
                .HasOptional(e => e.ACCOUNT)
                .WithRequired(e => e.STAFF);

            modelBuilder.Entity<STAFF>()
                .HasMany(e => e.IESLIPs)
                .WithRequired(e => e.STAFF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STAFF>()
                .HasMany(e => e.RECIEPTs)
                .WithRequired(e => e.STAFF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.WarehouseID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .HasMany(e => e.IESLIPs)
                .WithRequired(e => e.WAREHOUSE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WAREHOUSE>()
                .HasMany(e => e.PRODUCTAVAILABLEs)
                .WithRequired(e => e.WAREHOUSE)
                .WillCascadeOnDelete(false);
        }
    }
}
