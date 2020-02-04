using System;
using System.Collections.Generic;
using OnlineStore.Core.BLModel.Base;

namespace OnlineStore.Core.BLModel.Paged
{
    public class User  : BasePaged       
    {
        public IEnumerable<OnlineStore.Core.Data.Model.User> UserDetails { get; set; }
    }
}
