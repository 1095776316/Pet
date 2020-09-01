using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pet.Core
{
    public class PagedList<T> : IPageList<T>
    {

        public PagedList(IQueryable<T> source, int pageIndex, int pageSize, bool getOnlyTotalCount = false)
        {
            var total = source.Count();
            TotalCount = total;
            TotalPages = total / pageSize;

            if (total % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = PageIndex;
            if (getOnlyTotalCount)
                return;
            List = (source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IQueryable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            if (totalCount > 0 && pageIndex > 1)
            {
                TotalCount = totalCount;
            }
            else
            {
                TotalCount = source.Count();
            }
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;
            List = (source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList());
        }

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            TotalCount = totalCount;
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;
            List = source.ToList();
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => PageIndex > 0;

        public bool HasNextPage => PageIndex + 1 < TotalPages;

        public List<T> List { get; set; }
    }
}
