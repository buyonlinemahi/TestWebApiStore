using AutoMapper;
using OnlineStoreService.DTO;
using Core = OnlineStore.Core.Data.Model;
using Paged = OnlineStoreService.DTO.Paged;
using BLModel = OnlineStore.Core.BLModel.Paged;


namespace OnlineStoreWebApiService.Mapper
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            
            CreateMap<User, Core.User>();
            CreateMap<Core.User, User>();
            CreateMap<UserType, Core.UserType>();
            CreateMap<Core.UserType, UserType>();
            CreateMap<Paged.User, BLModel.User>();
            CreateMap<BLModel.User, Paged.User>();

            #region Category
            CreateMap<Category, Core.Category>();
            CreateMap<Core.Category, Category>();
            CreateMap<SubCategory, Core.SubCategory>();
            CreateMap<Core.SubCategory, SubCategory>();
            CreateMap<ProductSpecSubHeading, Core.ProductSpecSubHeading>();
            CreateMap<Core.ProductSpecSubHeading, ProductSpecSubHeading>();
            #endregion

            #region Product
            CreateMap<Product, Core.Product>();
            CreateMap<Core.Product, Product>();
            CreateMap<ProductImage, Core.ProductImage>();
            CreateMap<Core.ProductImage, ProductImage>();
            CreateMap<ProductSpecHeading, Core.ProductSpecHeading>();
            CreateMap<Core.ProductSpecHeading, ProductSpecHeading>();
            #endregion

            CreateMap<SellerProfile, Core.SellerProfile>();
            CreateMap<Core.SellerProfile, SellerProfile>();

            CreateMap<Coupon, Core.Coupon>();
            CreateMap<Core.Coupon, Coupon>();

            CreateMap<DiscountType, Core.DiscountType>();
            CreateMap<Core.DiscountType, DiscountType>();

            CreateMap<Paged.Coupon, BLModel.Coupon>();
            CreateMap<BLModel.Coupon, Paged.Coupon>();

            CreateMap<Productinventory, Core.Productinventory>();
            CreateMap<Core.Productinventory, Productinventory>();

            CreateMap<StockStatus, Core.StockStatus>();
            CreateMap<Core.StockStatus, StockStatus>();

            CreateMap<UnitMeasurement, Core.UnitMeasurement>();
            CreateMap<Core.UnitMeasurement, UnitMeasurement>();


        }
    }
}
