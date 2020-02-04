using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Data.Model;
using System;
using BLmodel = OnlineStore.Core.BLModel.Base;

namespace OnlineStore.Core.Data.SQLServer
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options) : base(options) { }

        #region TotalCount
        public virtual DbSet<BLmodel.BasePaged> BasePaged { get; set; } 
        #endregion

        #region User
        public virtual DbSet<User> Users { get; set; }
        #endregion

        #region Product
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductSpecHeading> ProductSpecHeadings { get; set; }
        public virtual DbSet<ProductSpecSubHeading> ProductSpecSubHeadings { get; set; }
        #endregion

        #region Category
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        #endregion

        #region Lookup
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<DiscountType> DiscountTypes { get; set; }
        public virtual DbSet<StockStatus> GetAllStatuses { get; set; }
        public virtual DbSet<UnitMeasurement> GetAllUnitMeasurement { get; set; }
        #endregion

        public virtual DbSet<SellerProfile> SellerProfiles { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Productinventory> Productinventories { get; set; }
       
    }
}
