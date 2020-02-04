using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    [Table(Constant.lookupTables.DiscountTypes, Schema = Constant.Schemas.lookup)]
    public class DiscountType
    {
        public int DiscountTypeID { get; set; }
        public string DiscountTypeName { get; set; }
    }
}
