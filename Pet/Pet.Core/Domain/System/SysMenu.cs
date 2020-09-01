using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Domain.System
{
    public class SysMenu : BaseEntity
    {
        public string PId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }

        public int Sort { get; set; }

        public bool Activited { get; set; }
    }
}
