using System;
using System.Linq;

public class Kata
{
    public static int ReverseNumber(int n)
    {
        string numberDigits = n.ToString();
        string result = numberDigits[0] == '-' ? $"-{string.Concat(numberDigits.Substring(1).Reverse().ToArray())}" : string.Concat(numberDigits.Reverse().ToArray());
        return Convert.ToInt32(result);

        // Alternative 1
        // return Math.Sign(n) * int.Parse(string.Concat($"{Math.Abs(n)}".Reverse()));

        // Alternative 2
        // return int.Parse(String.Join("", Math.Abs(n).ToString().Reverse())) * (n < 0 ? -1 : 1);
    }

    public static void Main(){
        Console.WriteLine(ReverseNumber(-123));
    }
}