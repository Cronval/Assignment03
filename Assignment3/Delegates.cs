using System;
using System.Collections.Generic;
using System.Linq;

/*
    NOT DONE
*/

namespace Assignment3
{
    public static class Delegates {
        public static IEnumerable<char> ReverseString(string input) 
        {
            Func<string,IEnumerable<char>> reverse = delegate(string s) { return s.Reverse(); };

            var output = reverse(input);
            var result = "".Concat<char>(output);

            Console.WriteLine(result);
            
            //(string s) => s.Reverse();

            return output;
        }
    }
}