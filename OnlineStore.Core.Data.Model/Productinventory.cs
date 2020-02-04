using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    public class Productinventory
    {
        [Key]
        public int ProductInventoryID { get; set; }
        public string SKU { get; set; }
        public bool IsManageStock { get; set; }
        [ForeignKey("StockStatusID")]
        public int StockStatusID { get; set; }
        [ForeignKey("MeasurementUnitID")]
        public int MeasurementUnitID { get; set; }
        [ForeignKey("ProductIID")]
        public int ProductIID { get; set; }
    }
}

