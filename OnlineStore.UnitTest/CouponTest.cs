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
    public class CouponTest
    {
        ICouponRepository _couponRepository;
         readonly OnlineStoreDbContext _context;

        public CouponTest()
        {
            var builder = new DbConnection();
            _context = new OnlineStoreDbContext((builder.InitConfiguration()).Options);
            _couponRepository = new CouponRepositoryImpl (_context);
        }

        [Fact]
        public void AddCoupon()
        {
            Coupon coupon = new Coupon
            {
                CouponCode = "Test12324",
                CouponComment = "Test",
                IsEnable = true,
                DiscountTypeID = 1,
                DiscountAmount = 00,
                ActiveFromDate = System.DateTime.Now,
                ActiveTillDate = System.DateTime.Now,
                SubtotalRangeBegin = 00,
                SubtotalRangeEnd = 0,      
                NumberOfUsers = 0         
              };
            var _id = _couponRepository.AddCoupon(coupon);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateCoupon()
        {
            Coupon coupon = new Coupon
            {
                CouponID = 4,
                CouponCode = "oooo",
                CouponComment = "oooo",
                IsEnable = true,
                DiscountTypeID = 1,
                DiscountAmount = 2000,
                ActiveFromDate = System.DateTime.Now,
                ActiveTillDate = System.DateTime.Now,
                SubtotalRangeBegin = 2000,
                SubtotalRangeEnd = 2000,
                NumberOfUsers = 2000
            };
            var _id = _couponRepository.UpdateCoupon(coupon);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void GetCouponByID()
        {
            var userByName = _couponRepository.GetCouponByID(4);
            Assert.True(userByName != null, "failed");
        }

        [Fact]
        public void GetCouponsByCode()
        {
            var couponByCode = _couponRepository.GetCouponsByCode("", 0, 50);
            Assert.True(couponByCode != null, "failed");
        }

    }
}
