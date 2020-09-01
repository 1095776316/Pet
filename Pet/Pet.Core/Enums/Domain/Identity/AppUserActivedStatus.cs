using Pet.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pet.Core.Enums.Domain.Identity
{
    public enum AppUserActivedStatus
    {
        [LocalizedDescription("NotActived")]
        NotActive = 0,

        [LocalizedDescription("Actived")]
        Actived = 1,
    }
}
