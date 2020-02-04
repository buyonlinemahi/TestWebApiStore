using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Core.Data.Model
{
    public class User
    {
        [Key]
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
        public DateTime?  ClearedOn { get; set; }
        public int? UserTypeID { get; set; }

    }
}
