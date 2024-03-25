// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;

namespace Converter
{
    public class Converter
    {
        public static string dnaToRna(string dna)
        {
            // Have fun! ^_^
            // string res = "";
            // char[] str = dna.ToCharArray();
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if(str[i].Equals('T')){
            //         str[i] = 'U';
            //     }
            //     res=res+str[i];
            // }
            // return res;
            return dna.Replace('T', 'U');
        }
        public static void Main()
        {
            Console.WriteLine(dnaToRna("TTTT"));
        }
    }
}