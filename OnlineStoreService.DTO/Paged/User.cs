using System.Collections.Generic;
using DTO = OnlineStoreService.DTO;

namespace OnlineStoreService.DTO.Paged
{
    public class User
    {
        public IEnumerable<DTO.User> UserDetails { get; set; }
        public int TotalCount { get; set; }
    }
}
