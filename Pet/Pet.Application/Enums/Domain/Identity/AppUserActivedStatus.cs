using Pet.Application.Attriubtes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pet.Application.Enums.Domain.Identity
{
    public enum AppUserActivedStatus
    {
        [LocalizedDescription("InActive")]
        InActive=0,

        [LocalizedDescription("Active")]
        Active =1,
    }
}
