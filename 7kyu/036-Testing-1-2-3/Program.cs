using System.Collections.Generic;
using System.Linq;
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
        //your code goes here
        return lines.Select((v,i)=>$"{i+1}: {v}").ToList();

    }

    public static void Main(){
        foreach (var item in Number(new List<string>{"a", "b", "c"}))
        {
            Console.WriteLine(item);
        }
    }
}