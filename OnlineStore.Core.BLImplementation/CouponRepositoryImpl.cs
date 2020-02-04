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
    public class CouponRepositoryImpl : ICouponRepository
    {
        private readonly BaseRepository<Coupon> _couponRepository;
        private readonly OnlineStoreDbContext _dbContext;
        public CouponRepositoryImpl(OnlineStoreDbContext DbContext)
        {
            _couponRepository = new BaseRepository<Coupon>(DbContext);
           
            _dbContext = DbContext;
        }

        public int AddCoupon(Coupon coupon)
        {
            return _couponRepository.Add(coupon).CouponID;
        }

        public int UpdateCoupon(Coupon coupon)
        {
            return _couponRepository.Update(coupon);
        }

        public void DeleteCoupon(int id)
        {
            _couponRepository.Delete(id);
        }

        public Coupon GetCouponByID(int _id)
        {
            return _couponRepository.GetById(_id);
        }

      public BLModel.Paged.Coupon GetCouponsByCode(string CouponCode, int Skip, int Take)
        {
            return new BLModel.Paged.Coupon
            {
                CouponDetails = _dbContext.Coupons.FromSql($"Get_CouponsByCode {CouponCode},{Skip},{Take}").ToList(),
                TotalCount = _dbContext.BasePaged.FromSql($"Get_CouponsByCodeCount {CouponCode}").Select(C => C.TotalCount).FirstOrDefault()
            };
        }
    }
}
