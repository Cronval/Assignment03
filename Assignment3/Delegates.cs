using System;
using System.Collections.Generic;
using System.Linq;

/*
    NOT DONE
*/

namespace Assignment3
{
    public static class Delegates {
        public static void ReverseString(string input) 
        {
            Action<string> reverse = s => s.Reverse().ToList().ForEach(c => Console.Write(c));

            reverse(input);

        }

        public static decimal Product(decimal x,decimal y) 
        {
            Func<decimal,decimal,decimal> product = (a,b) => a*b;

            return product(x,y);

        }

        public static bool NumEqual(int n, string s)
        {
            Func<int,string,bool> equal = (a,b) => int.Parse(b) == a;

            return equal(n,s);
        }
    }
}