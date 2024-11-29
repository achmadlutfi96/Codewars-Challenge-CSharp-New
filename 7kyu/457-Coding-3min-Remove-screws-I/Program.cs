using System;
using System.Linq;

public static class Kata
{
    public static int Sc(string screws)
    {
        int res = 0;
        for (int i = 0; i < screws.Length; i++)
        {
            res += 1;
            if (i + 1 != screws.Length)
            {
                if (screws[i] != screws[i + 1])
                {
                    res += 5;
                }
                res += 1;
            }
        }
        return res;

        // Alternative 1
        // return screws.Select((c, i) => i == 0 ? 1 : c == screws[i - 1] ? 2 : 7).Sum();

        // Alternative 2
        // int t = screws.Length * 2 - 1;
        //   for(int i = 1; i < screws.Length; i++){
        //     if(screws[i] != screws[i - 1]) t += 5;
        //   }
        //   return t;
    }

    public static void Main()
    {
        Console.WriteLine(Sc("-+-+-+"));
    }
}