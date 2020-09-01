using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.Identity
{
    public class AppRoleMenu : BaseEntity
    {
        public int RoleId { get; set; }
        public int MenuId { get; set; }
    }
}
