using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Extensions
{
    public static class IntExtension
    {
        public static int ConvertToInt(this object _t)
        {
            if (_t == null)
            {
                throw new ArgumentNullException("_t");
            }
            int r = 0;
            int.TryParse(_t.ToString(),out r);
            return r;
        }
    }
}
