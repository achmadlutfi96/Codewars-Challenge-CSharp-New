using System;
using System.Linq;

public class Solution
{    
    public static string solve(string eq){
        //..
        string[] v = eq.Replace("*", " ").Replace("+", " ").Replace("-", " ").Replace("/", " ").Split(" ").Reverse().ToArray();
        char[] o = eq.Where(x=>"*+-/".Contains(x)).Reverse().ToArray();
        string res = ""; 
        for (int i = 0; i < v.Length; i++)
        {
            res+=v[i];
            if(i != v.Length-1){
                res+=o[i];
            }
        }
        return res;

        // Alternative 1
        // return string.Concat(
        // eq.Split("+-*/".ToArray()).Reverse()
        // .Zip(
        //     eq.Where(c => "+-*/".Contains(c)).Select(c => $"{c}").Reverse().Append("")
        //     , (m, o) => m + o));

        // Alternative 2
        // return string.Join("", Regex.Split(eq, @"(\*)|(\+)|(-)|(/)").Reverse());

        // Alternative 3
        // return string.Concat(Regex.Matches(eq, @"\w+|.").Reverse());
    }

    public static void Main(){
        Console.WriteLine(solve("a+b-c/d*30"));
        Console.WriteLine(solve("100*b/y"));
    }
}