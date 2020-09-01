using Microsoft.AspNetCore.Mvc.Rendering;
using Pet.Core.Attributes;
using Pet.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.Helper.Enums
{
    public static class EnumHelper
    {
        public static string GetDescription(Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            string description = value.ToString();

            Type eunmtype = value.GetType();

            return GetEnumDescription(eunmtype, description);
        }

        public static string GetEnumDescription(Type enumType, string name)
        {
            try
            {
                LocalizedDescriptionAttribute[] attributes = (LocalizedDescriptionAttribute[])enumType.GetField(name)?.GetCustomAttributes(typeof(LocalizedDescriptionAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    name = attributes[0].Description;
                }
                else
                {
                    name = name.ToString();
                }
                return name;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static List<SelectListItem> GetListSelectListItem<T>(int selectedValue) where T : Enum
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var _type = typeof(T);
            foreach (T _enum in Enum.GetValues(_type))
            {
                string _description = GetEnumDescription(_enum.GetType(), _enum.ToString());
                var _v = Convert.ToInt32(_enum);
                var _isSelected = selectedValue == _v;
                list.Add(new SelectListItem()
                {
                    Value = _v.ToString(),
                    Text = _description,
                    Selected = _isSelected
                });
            }
            return list;
        }
    }
}
