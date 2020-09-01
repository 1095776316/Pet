using Pet.Core.Enums.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Models.Users
{
    public class UserPageModel : BaseEntity
    {
        public AppUserTypeStauts UserType { get; set; }

        public string UserTypeDesc { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public string CreatorUserName { get; set; }

        public bool Actived { get; set; }

        public string ActivedDesc { get; set; }

        public bool Deleted { get; set; }

        public string DeletedDesc { get; set; }
    }
}
