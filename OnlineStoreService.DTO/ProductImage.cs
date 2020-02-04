using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStoreService.DTO
{
    public class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }
        public string ProductPhoto { get; set; }
        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
    }
}
