using Pet.Core.Enums.Pages;
using Pet.Core.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Extensions
{
    public static class IPageListExtension
    {
        public static LayuiPageDto<T> LayuiPageResult<T>(
            this IPageList<T> ts,
            LayuiPageCodeStatus status = LayuiPageCodeStatus.Success)
            where T : class, new()
        {
            LayuiPageDto<T> dto = new LayuiPageDto<T>()
            {
                  Code = (int)status,
                  Count=ts.TotalCount,
                  Data=ts.List
            };
            return dto;
        }
    }
}
