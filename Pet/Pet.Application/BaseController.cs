using Pet.Core;
using Microsoft.AspNetCore.Mvc;
using Pet.Core.Extensions;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using static Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary;
using System;
using Pet.Core.Enums;

namespace Pet.Application
{
    public class BaseController : Controller
    {
        public IStringLocalizer L;
        public IActionResult LayuiPageResult<T>(IPageList<T> ts)
            where T : class, new()
        {
            var result = ts.LayuiPageResult();
            return Json(result);
        }

        public IActionResult Success(object data)
        {
            JsonResultDto result = new Core.JsonResultDto()
            {
                Code = ReponseStatus.Success,
                Message = L["OperationSuccessful"],
                Data = data,
                Errors = null
            };
            return Json(result);
        }

        public IActionResult Error(Dictionary<string, string> errors)
        {
            JsonResultDto result = new Core.JsonResultDto()
            {
                Code = ReponseStatus.Success,
                Message = L["OperationFailed"],
                Data = null,
                Errors = errors.Values
            };
            return Json(result);
        }

        public IActionResult Error(ValueEnumerable valueEnumerable)
        {
            List<string> errors = new List<string>();
            foreach (var item in valueEnumerable)
            {
                foreach (var temp in item.Errors)
                {
                    errors.Add(temp.ErrorMessage);
                }
            }
            JsonResultDto result = new Core.JsonResultDto()
            {
                Code = ReponseStatus.Success,
                Message = L["OperationFailed"],
                Data = null,
                Errors = errors
            };
            return Json(result);
        }

        public IActionResult ForbidResult()
        {
            return new ForbidResult();
        }

    }
}
