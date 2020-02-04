using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    public class Coupon
    {
        [Key]
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public string CouponComment { get; set; }
        public bool IsEnable { get; set; }        
        public int DiscountTypeID { get; set; }
        public int DiscountAmount { get; set; }
        public DateTime ActiveFromDate { get; set; }
        public DateTime ActiveTillDate { get; set; }
        public int SubtotalRangeBegin { get; set; }
        public int SubtotalRangeEnd { get; set; }
        public int NumberOfUsers { get; set; }
    }
}

