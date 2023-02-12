using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSTask7
{
    static class ReverseMethod
    {
        public static string ReverseString(this string x)
        {
            char[] arr = x.ToCharArray();   
            Array.Reverse(arr);
            string s = new string(arr);
            return s;
        }
    }
}
