using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Right(this string input, int numChars)
        {
            if(String.IsNullOrEmpty(input))
            {
                return String.Empty;
            }

            return input.Substring(input.Length - numChars);
        }
    }
}
