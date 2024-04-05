using System;
using System.Linq;

public class Kata
{
    public static string Well(string[] x)
    {
        int result = x.Where(i=>i.Equals("good")).Count();
        if (  result == 1 || result == 2)
        {
            return "Publish!";
        }else if(result > 2){
            return "I smell a series!";
        }else{
            return "Fail!";
        }

        // Alternative
        // int count = x.Count(v => v == "good");
        // return (count > 2) ? "I smell a series!" : (count >= 1) ? "Publish!" : "Fail!";
    }

    public static void Main()
    {
        Console.WriteLine(Well(new string[] { "bad", "bad", "bad" }));
        Console.WriteLine(Well(new string[] { "good", "bad", "bad", "bad", "bad" }));
        Console.WriteLine(Well(new string[] { "good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good" }));
    }
}