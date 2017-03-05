using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtensionDemo
{
    public static class stringHelper
    {
        public static string changeFirstLetterCase(this string str)
        {
            char[] charArray = str.ToCharArray();

            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);

            return new string(charArray);
        } 
    }
}
