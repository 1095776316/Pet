using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.Identity
{
    public class AppPermission : BaseEntity
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
