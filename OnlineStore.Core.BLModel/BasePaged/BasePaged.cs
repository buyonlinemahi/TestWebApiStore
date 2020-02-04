using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineStore.Core.BLModel.Base
{
    public class BasePaged
    {
        [Key]
        public int TotalCount { get; set; }
    }
}
