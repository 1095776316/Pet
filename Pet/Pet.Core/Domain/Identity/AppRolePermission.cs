using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.Identity
{
    public class AppRolePermission : BaseEntity
    {
        public int RoleId { get; set; }

        public int PermissionId { get; set; }
    }
}
