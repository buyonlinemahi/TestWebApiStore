using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.BL;
using OnlineStore.Core.BLImplementation;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using System;
using Xunit;

namespace OnlineStore.UnitTest
{
    public class SellerProfileTest
    {
        ISellerRepository _sellerRepository;
        readonly OnlineStoreDbContext _context;

        public SellerProfileTest()
        {
            var builder = new DbConnection();
            _context = new OnlineStoreDbContext((builder.InitConfiguration()).Options);
            _sellerRepository = new SellerRepositoryImpl(_context);
        }

        [Fact]
        public void AddsellerProfile()
        {
            SellerProfile sellerProfile = new SellerProfile
            {
                BusinessTitle = "demo333",
                CompanyName = "demo3242",
                StreetAddress = "demo3242",
                City = "demo3242",
                State = "demo3242",
                Country = "demo333", 
                ZipCode = "234243",
                PhoneNumber = "23423423",
                NumberOfProducts = 2,
                MerchantID = 12345667891,
                UserID = 15,
            };
            var _id = _sellerRepository.AddSellerProfile(sellerProfile);
            Assert.True(_id > 0, "failed");
        }




        [Fact]
        public void UpdatesellerProfile()
        {
            SellerProfile sellerProfile = new SellerProfile
            {
                SellerProfileID = 2,
                BusinessTitle = "Jassa",
                CompanyName = "Jassa",
                StreetAddress = "Jassa",
                City = "Jassa",
                State = "Jassa",
                Country = "Jassa",
                ZipCode = "Jassa",
                PhoneNumber = "Jassa",              
                NumberOfProducts = 2,
                MerchantID = 12345667891,
                UserID = 15,
            };
            var _id = _sellerRepository.UpdateSellerProfile(sellerProfile);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void GetSellerProfileByID()
        {
            var userByName = _sellerRepository.GetSellerProfileByUserID(15);
            Assert.True(userByName != null, "failed");
        }

        [Theory]
        [InlineData(3)]
        public void GetProductByID(int ID)
        {
            var SellerProfileByID = _sellerRepository.GetSellerProfileByID(ID);
            Assert.True(SellerProfileByID != null, "failed");
        }

    }
}
