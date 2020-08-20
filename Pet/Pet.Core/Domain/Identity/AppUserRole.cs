using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.Identity
{
    public class AppUserRole : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
