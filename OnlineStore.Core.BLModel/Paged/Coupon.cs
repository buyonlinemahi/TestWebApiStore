using System;
using System.Collections.Generic;
using OnlineStore.Core.BLModel.Base;


namespace OnlineStore.Core.BLModel.Paged
{
   public class Coupon:BasePaged
    {
        public IEnumerable<OnlineStore.Core.Data.Model.Coupon> CouponDetails { get; set; }
    }
}
