using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Demo
{
    public static class EnumExtention
    {
        public static string Color<T>(this T item) where T : Enum
        {
            return item.GetEnumMemberAttrValue().Color;
        }
        public static EnumDetails GetEnumMemberAttrValue(this Enum enumText)
        {

            var enumType = enumText.GetType().GetField(enumText.ToString());
            if (enumType == null)
            {
                return new EnumDetails() { Value = -1, Color = "", DefualtText = enumText.ToString(), Text = enumText.ToString() };
            }

            var attr = (EnumCustomMemberAttribute)enumType.GetCustomAttribute(typeof(EnumCustomMemberAttribute));
            //var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumCustomMemberAttribute>().FirstOrDefault();
            return
                new EnumDetails()
                {
                    Text = attr?.Text ?? "",
                    Color = attr?.Color ?? "",
                    DefualtText = enumText.ToString(),
                    Value = Convert.ToInt32(enumText),
                    CssClass = attr?.CssClas ?? "",
                    Name = AttributeHelper.Text(enumText.GetType())
                };
        }
        public static Guid GetDBIDAttribute(this Enum enumText)
        {

            var enumType = enumText.GetType().GetField(enumText.ToString());
            if (enumType == null)
            {
                return default;
            }

            var attr = (DatabaseIDAttribute)enumType.GetCustomAttribute(typeof(DatabaseIDAttribute));

            if (attr == null)
            {
                throw new Exception("Attribute not set for this Enum value");
            }

            return Guid.Parse(attr.ID);
        }
        public static string Text<T>(this T item) where T : Enum
        {
            var txt = item.GetEnumMemberAttrValue().Text;
            return !string.IsNullOrEmpty(txt) ? txt : item.ToString();
        }
    }
}
