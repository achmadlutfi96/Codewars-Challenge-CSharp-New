// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        //Code it!
        string res = "";
        foreach (char s in input)
        {
            if(!String.Equals(s,' ')){
                // res = String.Concat(res, s);
                res+=s;
            }
        }
        return res;

        // Alternative
        // return input.Replace(" ", string.Empty);
    }

    public static void Main(){
        Console.WriteLine(NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
    }  
  }
}
