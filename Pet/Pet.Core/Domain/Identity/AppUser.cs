using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.Identity
{
    public class AppUser : BaseEntity
    {
        public string Name { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public int DeleterUserId { get; set; }

        public DateTime DeletionTime { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool Actived { get; set; }

        public bool Deleted { get; set; }

    }
}
