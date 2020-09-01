using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core
{
    public interface IPageList<T> 
    {
        List<T> List { get; set; }

        int PageIndex { get; set; }

        int PageSize { get; set; }

        int TotalCount { get; set; }

        int TotalPages { get; set; }

        bool HasPreviousPage { get; }

        bool HasNextPage { get; }
    }
}
