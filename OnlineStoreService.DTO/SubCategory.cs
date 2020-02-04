using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStoreService.DTO
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
    }
}
