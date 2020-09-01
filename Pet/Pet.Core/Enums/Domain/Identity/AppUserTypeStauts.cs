using Pet.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Enums.Domain.Identity
{
    public enum AppUserTypeStauts
    {
        [LocalizedDescription("Guest")]
        Guest=0,

        [LocalizedDescription("Member")]
        Member =1,

        [LocalizedDescription("Admin")]
        Admin =2,

        [LocalizedDescription("SuperAdmin")]
        SuperAdmin =3
    }
}
