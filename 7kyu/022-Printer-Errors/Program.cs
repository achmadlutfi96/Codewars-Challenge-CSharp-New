using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        // your code
        int n = s.Length;
        int v = s.Where(x => !Regex.IsMatch(x.ToString(),@"[a-m]")).Count();
        return $"{v}/{n}";

        // Alternative
        // return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }

    public static void Main(){
        Console.WriteLine(PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
    }
}