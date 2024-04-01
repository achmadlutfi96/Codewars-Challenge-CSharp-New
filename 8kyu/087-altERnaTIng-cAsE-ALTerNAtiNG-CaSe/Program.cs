// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
    //   throw new NotImplementedException();
        return String.Join("", s.Select(v => v == char.ToUpper(v) ? char.ToLower(v): char.ToUpper(v)));
        // Alternative
        // return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
    }
    public static void Main(){
        Console.WriteLine("hello world".ToAlternatingCase());
    }
  }
}
