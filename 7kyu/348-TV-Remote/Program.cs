using System;
public class Dinglemouse
{
    public static int TvRemote(string word)
    {
        // Your code here
        char[,] remote = new[,] {
            {'a','b','c','d','e','1','2','3'},
            {'f','g','h','i','j','4','5','6'},
            {'k','l','m','n','o','7','8','9'},
            {'p','q','r','s','t','.','@','0'},
            {'u','v','w','x','y','z','_','/'}
        };

        int[] p1 = new[] { 0, 0 };
        int[] p2 = new[] { 0, 0 };

        int res = 0;

        foreach (char c in word)
        {
            int step = 0;
            for (int i = 0; i < remote.GetLength(0); i++)
            {
                for (int j = 0; j < remote.GetLength(1); j++)
                {
                    if (remote[i, j] == c)
                    {
                        p2[0] = i;
                        p2[1] = j;
                        break;
                    }
                }
            }
            step = Math.Abs(p2[0] - p1[0]) + Math.Abs(p2[1] - p1[1]) + 1;
            p1[0] = p2[0];
            p1[1] = p2[1];
            res += step;
        }
        return res;
    }

    public static void Main()
    {
        Console.WriteLine(TvRemote("codewars"));
        Console.WriteLine(TvRemote("solution"));
    }
}