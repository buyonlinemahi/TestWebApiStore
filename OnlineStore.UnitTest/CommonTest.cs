using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.BL;
using OnlineStore.Core.BLImplementation;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using System;
using System.Collections.Generic;
using Xunit;

namespace OnlineStore.UnitTest
{
    public class CommonTest
    {
        ICommonRepository commonRepository;
        readonly OnlineStoreDbContext _context;

        public CommonTest()
        {
            var builder = new DbConnection();
            _context = new OnlineStoreDbContext((builder.InitConfiguration()).Options);
            commonRepository = new CommonRepositoryImpl(_context);
        }

        [Fact]
        public void getAllUserTypes()
        {
            IEnumerable<UserType> userTypes = commonRepository.GetUserTypes();
            Assert.True(userTypes != null, "failed");
        }

        [Fact]
        public void getAllCategory()
        {
            IEnumerable<Category> categories = commonRepository.getAllCategory();
            Assert.True(categories != null, "failed");
        }

        [Fact]
        public void getAllSubCategory()
        {
            IEnumerable<SubCategory> subCategories = commonRepository.getAllSubCategory();
            Assert.True(subCategories != null, "failed");
        }

       
        [Theory]
        [InlineData(14)]
        public void GetSubCategoryByID(int ID)
        {
            IEnumerable<SubCategory> subCategories = commonRepository.GetSubCategoryByCategoryID(ID);
            Assert.True(subCategories != null, "failed");
        }

        [Fact]
        public void getAllDiscountType()
        {
            IEnumerable<DiscountType> discountTypes= commonRepository.GetDiscountTypes();
            Assert.True(discountTypes != null, "failed");
        }


        [Fact]
        public void getAllProducts()
        {
            IEnumerable<Product> products = commonRepository.GetAllProducttypes();
            Assert.True(products != null, "failed");
        }

        [Fact]
        public void getAllSpecHeading()
        {
            IEnumerable<ProductSpecHeading> productSpecHeadings = commonRepository.GetAllSpecHeading();
            Assert.True(productSpecHeadings != null, "failed");
        }

        [Fact]
        public void GetAllStatuses()
        {
            IEnumerable<StockStatus> stockStatuses = commonRepository.GetAllStatuses();
            Assert.True(stockStatuses != null, "failed");
        }

        [Fact]
        public void GetAllUnitMeasurement()
        {
            IEnumerable<UnitMeasurement> unitMeasurements = commonRepository.GetAllUnitMeasurement();
            Assert.True(unitMeasurements != null, "failed");
        }
    }
}
