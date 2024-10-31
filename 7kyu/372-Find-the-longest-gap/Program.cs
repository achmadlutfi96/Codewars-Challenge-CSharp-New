using System;
using System.Linq;

public class Kata
{
    public static int Gap(int num)
    {
        //Your code goes here!
        if (Convert.ToString(num, 2).StartsWith('0') && Convert.ToString(num, 2).EndsWith('0'))
        {
            return Convert.ToString(num, 2).Split('1').Skip(1).SkipLast(1).Select(x => x.Length).Max();
        }
        else if (Convert.ToString(num, 2).StartsWith('0'))
        {
            return Convert.ToString(num, 2).Split('1').Skip(1).Select(x => x.Length).Max();
        }
        else if (Convert.ToString(num, 2).EndsWith('0'))
        {
            return Convert.ToString(num, 2).Split('1').SkipLast(1).Select(x => x.Length).Max();
        }
        else
        {
            return Convert.ToString(num, 2).Split('1').Select(x => x.Length).Max();
        }

        // Alternative 1
        // var binary = Convert.ToString(num, 2);
        // return binary.Trim('0').Split('1').Select(s => s.Length).Max();

        // Alternative 2
        // return Regex.Matches(Convert.ToString(num, 2), "(?<=1)0+(?=1)").Select(x => x.Value.Length).DefaultIfEmpty().Max();

    }

    public static void Main()
    {
        Console.WriteLine(Gap(9));
        Console.WriteLine(Gap(529));
        Console.WriteLine(Gap(20));
        Console.WriteLine(Gap(15));
    }
}