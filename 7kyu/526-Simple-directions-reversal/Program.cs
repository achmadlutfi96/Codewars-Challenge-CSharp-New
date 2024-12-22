using System;
using System.Linq;
public class Solution
{
    public static string[] solve(string[] arr)
    {
        //..
        String[] ret = new String[arr.Length];
        string dir = "Begin";
        for (int i = 0; i < arr.Length; i++)
        {
            String s = arr[arr.Length - 1 - i];
            ret[i] = dir + s.Substring(s.IndexOf(" "));
            dir = s.Substring(0, s.IndexOf(" ")).Equals("Left") ? "Right" : "Left";
        }
        return ret;

        // Alternative
        // var dirs = arr.Reverse().Select(x => x.StartsWith("Right") ? "Left" : x.StartsWith("Left") ? "Right" : "").ToArray();
        // return arr.Reverse().Select((x, i) => (i == 0 ? "Begin" : dirs[i - 1]) + x[x.IndexOf(' ')..]).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(String.Join(", ", solve(new String[] { "Begin on Road A", "Right on Road B", "Right on Road C", "Left on Road D" })));
    }
}