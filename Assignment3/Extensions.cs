using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri)
        {
            if (uri.Scheme == Uri.UriSchemeHttps)
            {
                return true;
            }
            return false;
        }

        public static int WordCount(this string input)
        {
            var split = input.Split(" ");
            return split.Length;
        }
    }
}