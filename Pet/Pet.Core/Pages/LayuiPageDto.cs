using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Pages
{
    public class LayuiPageDto<T>
        where T : class, new()
    {
        public int Code { get; set; }

        public int Count { get; set; }

        public IList<T> Data { get; set; }
    }
}
