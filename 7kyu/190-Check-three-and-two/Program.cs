using System;
using System.Linq;

public class Kata
{
    public static bool CheckThreeAndTwo(string[] array)
    {
        // throw (new NotImplementedException());
        int[] res = array.Distinct().Select(x=>array.Count(y=>y==x)).ToArray();
        return res.Contains(2) && res.Contains(3);

        // Alternative
        // var gData = array.GroupBy(x=>x).Select(x=>x.Count()).ToList();
        // return (gData.Any(x=>x==3) && gData.Any(x=>x==2));
    }

    public static void Main(){
        Console.WriteLine(CheckThreeAndTwo(new string[] { "a", "a", "a", "b", "b" }));
    }
}