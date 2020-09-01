using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.System
{
    public class SysMenuPermission : BaseEntity
    {
        public int MenuId { get; set; }
        public int PermissionId { get; set; }
        public int Sort { get; set; }
    }
}
