using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.Identity
{
    public class AppRole : BaseEntity
    {
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
