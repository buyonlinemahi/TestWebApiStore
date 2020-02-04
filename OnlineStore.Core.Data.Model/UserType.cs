using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Core.Data.Model
{
    [Table(Constant.lookupTables.UserType, Schema = Constant.Schemas.lookup)]
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UserName { get; set; }
    }
}
