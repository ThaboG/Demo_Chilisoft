using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public static class StringExtension
    {
        public static Guid ToGuid(this string strData)
        {
            if (Guid.TryParse(strData, out Guid res))
            {
                return res;
            }
            else
            {
                throw new Exception($"\"{strData}\" is not a valid guid");
            }
        }

        public static bool CaseSensitiveCompare(this string str1, string str2)
        {
            return string.Compare(str1, str2, false) == 0;
        }
    }
}
