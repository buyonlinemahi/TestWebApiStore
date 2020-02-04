using System.Collections.Generic;
using DTO = OnlineStoreService.DTO;

namespace OnlineStoreService.DTO.Paged
{
   public class Coupon
    {
        public IEnumerable<DTO.Coupon> CouponDetails { get; set; }
        public int TotalCount { get; set; }
    }
}
