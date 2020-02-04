using System;

namespace OnlineStoreService.DTO
{
    public class User
        {
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }
            public string EmailID { get; set; }
            public string Phone { get; set; }
            public bool? IsActive { get; set; }
            public bool? IsLocked { get; set; }
            public int? FailedAttemptCount { get; set; }
            public DateTime? LastLoginDate { get; set; }
            public DateTime? ClearedOn { get; set; }
            public int? UserTypeID { get; set; }
    }
}
