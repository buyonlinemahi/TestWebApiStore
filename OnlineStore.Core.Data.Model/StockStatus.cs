using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OnlineStore.Core.Data.Model
{
    [Table(Constant.lookupTables.StockStatus, Schema = Constant.Schemas.lookup)]
    public class StockStatus
    {
        [Key]
        public int StockStatUsID { get; set; }
        public string StatusName { get; set; }
    }
}

