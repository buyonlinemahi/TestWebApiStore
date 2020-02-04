using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;

namespace OnlineStore.Core.BL
{
    public interface ICouponRepository
    {
        int AddCoupon(Coupon coupon);
        int UpdateCoupon(Coupon coupon);
        void DeleteCoupon(int id);
        Coupon GetCouponByID(int _id);
        BLModel.Paged.Coupon GetCouponsByCode(string CouponCode, int Skip, int Take);
    }
}
