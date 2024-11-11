using System;
using System.Linq;
public class Composing
{

    public static string Compose(string s1, string s2)
    {
        // your code
        string[] arrS1 = s1.Split("\n").ToArray();
        string[] arrS2 = s2.Split("\n").Reverse().ToArray();
        return string.Join("\n", arrS1.Select((v, i) => v.Substring(0, i + 1) + arrS2[i].Substring(0, arrS2[i].Length - i)));

        // Alternative 
        // return string.Join("\n", Enumerable.Range(1, 1000)
        // .Zip(s1.Split('\n'), (i,a) => (i, a))
        // .Zip(s2.Split('\n').Reverse(), (_, b) => (_.i , _.a, b))
        // .Select(_ => string.Concat( _.a.Take(_.i).Concat(_.b.SkipLast(_.i-1)))));
    }

    public static void Main()
    {
        Console.WriteLine(Compose("byGt\nhTts\nRTFF\nCnnI", "jIRl\nViBu\nrWOb\nNkTB"));
    }
}