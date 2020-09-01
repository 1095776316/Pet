using Pet.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Enums.Domain.Identity
{
    public enum AppUserDeletedStatus
    {
        [LocalizedDescription("NotDeleted")]
        NotDeleted = 0,

        [LocalizedDescription("Deleted")]
        Deleted = 1,
    }
}
