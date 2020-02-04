using OnlineStore.Core.BL;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Omu.ValueInjecter;

namespace OnlineStore.Core.BLImplementation
{
   public class CommonRepositoryImpl : ICommonRepository
    {
        private readonly BaseRepository<Category> _categoryRepository;
        private readonly BaseRepository<SubCategory> _subCategoryRepository;
        private readonly BaseRepository<UserType> _userTypeRepository;
        private readonly BaseRepository<DiscountType> _discountTypeRepository;
        private readonly BaseRepository<Product> _productrepository;
        private readonly BaseRepository<ProductSpecHeading> _specHeadingRepository;
        private readonly BaseRepository<StockStatus> _statusRepository;
        private readonly BaseRepository<UnitMeasurement> _unitRepository;
        private readonly OnlineStoreDbContext _dbContext;
        public CommonRepositoryImpl(OnlineStoreDbContext DbContext)
        {
            _categoryRepository = new BaseRepository<Category>(DbContext);
            _subCategoryRepository = new BaseRepository<SubCategory>(DbContext);
            _userTypeRepository = new BaseRepository<UserType>(DbContext);
            _discountTypeRepository = new BaseRepository<DiscountType>(DbContext);
            _productrepository = new BaseRepository<Product>(DbContext);
            _specHeadingRepository = new BaseRepository<ProductSpecHeading>(DbContext);
            _statusRepository = new BaseRepository<StockStatus>(DbContext);
            _unitRepository = new BaseRepository<UnitMeasurement>(DbContext);
            _dbContext = DbContext;
        }

        public IEnumerable<UserType> GetUserTypes()
        {
            IEnumerable<UserType> userTypes = _userTypeRepository.GetAll().Select(ut => new UserType().InjectFrom(ut)).Cast<UserType>().OrderBy(ut => ut.UserName).ToList();
            return userTypes;
        }

        public IEnumerable<Category> getAllCategory()
        {
            IEnumerable<Category> categories = _categoryRepository.GetAll().Select(js => new Category().InjectFrom(js)).Cast<Category>().OrderBy(js => js.CategoryName).ToList();
            return categories;
        }

        public IEnumerable<SubCategory> getAllSubCategory()
        {
            IEnumerable<SubCategory> subCategories = _subCategoryRepository.GetAll().Select(js => new SubCategory().InjectFrom(js)).Cast<SubCategory>().OrderBy(js => js.SubCategoryName).ToList();
            return subCategories;
        }

        public IEnumerable<SubCategory> GetSubCategoryByCategoryID(int categoryID)
        {
            IEnumerable<SubCategory> subCategories = _subCategoryRepository.GetAll().Where(SB => SB.CategoryID == categoryID).ToList();
            return subCategories;
        }

        public IEnumerable<DiscountType> GetDiscountTypes()
        {
            IEnumerable<DiscountType> discountTypes = _discountTypeRepository.GetAll().Select(DT => new DiscountType().InjectFrom(DT)).Cast<DiscountType>().OrderBy(DT => DT.DiscountTypeName).ToList();
            return discountTypes;
        }

        public IEnumerable<Product> GetAllProducttypes()
        {
            IEnumerable<Product> products = _productrepository.GetAll().Select(p => new Product().InjectFrom(p)).Cast<Product>().OrderBy(p => p.Title).ToList();
            return products;
        }

        public IEnumerable<ProductSpecHeading> GetAllSpecHeading()
        {
            IEnumerable<ProductSpecHeading> productSpecHeadings = _specHeadingRepository.GetAll().Select(PSH => new ProductSpecHeading().InjectFrom(PSH)).Cast<ProductSpecHeading>().OrderBy(PSH => PSH.SpecHeadingTitle).ToList();
            return productSpecHeadings;
        }

        public IEnumerable<StockStatus> GetAllStatuses()
        {
            IEnumerable<StockStatus> stockStatuses = _statusRepository.GetAll().Select(S => new StockStatus().InjectFrom(S)).Cast<StockStatus>().OrderBy(S => S.StatusName).ToList();
            return stockStatuses;
        }

        public IEnumerable<UnitMeasurement> GetAllUnitMeasurement()
        {
            IEnumerable<UnitMeasurement> unitMeasurements = _unitRepository.GetAll().Select(U => new UnitMeasurement().InjectFrom(U)).Cast<UnitMeasurement>().OrderBy(U => U.MeasurementUnitName).ToList();
            return unitMeasurements;
        }
    }
}
