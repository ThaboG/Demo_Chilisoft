using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public sealed class AttributeHelper
    {
        public static EnumCustomMemberAttribute GetEnumAttribute(Type t)
        {
            return (EnumCustomMemberAttribute)Attribute.GetCustomAttribute(t, typeof(EnumCustomMemberAttribute));
        }

        public static string Text(Type t)
        {
            return GetEnumAttribute(t)?.Text ?? t.GetType().Name;
        }
    }
}
