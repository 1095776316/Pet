using Pet.Application.Attriubtes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pet.Application.Helper
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
                LocalizedDescriptionAttribute[] attributes = (LocalizedDescriptionAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(LocalizedDescriptionAttribute), false);
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
    }
}
