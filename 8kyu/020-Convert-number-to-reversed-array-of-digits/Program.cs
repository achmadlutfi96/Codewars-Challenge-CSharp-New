// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            // Code goes here
            string str = n.ToString(); // Conververt to string 
            char[] charArr = str.ToCharArray(); // convert to char Array
            Array.Reverse(charArr); // reverse character
            return Array.ConvertAll(charArr, a => (Int64) char.GetNumericValue(a)); // convert all to long
            // char.GetNumericValue() digunakan untuk mencari unicode dari karakter 

            // ALTERNATIVE 
            // return n.ToString().Reverse().Select(t => Convert.ToInt64(t.ToString())).ToArray();
        }
        public static void Main()
        {
            Console.WriteLine(Digitize(35231));
        }
    }
}
