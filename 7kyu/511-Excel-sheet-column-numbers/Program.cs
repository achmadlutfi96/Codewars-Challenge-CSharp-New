using System;
using System.Linq;
public class ExcelToNumber {
    public static long TitleToNumber(string title) {
        // your code
        return title.Reverse().Select((v,i)=> (v-64)*(long)Math.Pow(26, i)).Sum();
        
    }

    public static void Main()
    {
        Console.WriteLine(TitleToNumber("A"));
        Console.WriteLine(TitleToNumber("AA"));
        Console.WriteLine(TitleToNumber("AZ"));
        Console.WriteLine(TitleToNumber("BA"));
        Console.WriteLine(TitleToNumber("CODEWARS"));
    }
}