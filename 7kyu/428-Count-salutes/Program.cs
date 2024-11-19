using System;

public static class Kata
{
    public static int CountSalutes(string hallway)
    {
        int sum = 0;
        for (int i = 0; i < hallway.Length - 1; i++)
        {
            for (int j = i+1; j < hallway.Length; j++)
            {
                if ((hallway[i] == '>') && (hallway[j] == '<'))
                {
                    sum+=2;
                }
            }
        }
        return sum;

        // Alternative 
        // return hallway.Select((p, i) => p=='>' ? hallway.Skip(i).Count(p => p=='<') : 0).Sum() * 2;
    }

    public static void Main()
    {
        Console.WriteLine(CountSalutes("<---->---<---<-->"));
    }
}