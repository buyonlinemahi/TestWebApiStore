using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string MRP { get; set; }
        public string Price { get; set; }
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        [ForeignKey("SubCategoryID")]
        public int SubCategoryID { get; set; }
        public string Description { get; set; }
       
    }
}
 