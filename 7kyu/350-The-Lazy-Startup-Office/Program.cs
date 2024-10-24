using System;
using System.Linq;

public class Kata
{
    public static string[] BinRota(string[][] input)
    {
        if (input.Length == 0){
            return new string[]{};
        }
        return input.Select((v,i)=>(i+1)%2==0?v.Reverse().ToArray():v).Aggregate((v,n)=>v.Concat(n).ToArray());

        // Alternative 
        // return  input.SelectMany((e, i) => i%2 == 0 ? e : e.Reverse()).ToArray();
    }

    public static void Main(){
        var testInput = new string[][] { new[] { "Bob", "Nora" }, new[] { "Ruby", "Carl"} };
        Console.WriteLine(string.Join(",", BinRota(testInput)));
    }
}