using System;

public static class Kata
{
    public static string Doubles(string str)
    {

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                str = str.Remove(i, 2);
                i = -1;
            }
        }
        return str;
    }

    public static void Main()
    {
        Console.WriteLine(Doubles("rrrmooomqqqqj"));
    }
}