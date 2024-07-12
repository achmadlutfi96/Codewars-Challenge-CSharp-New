using System;
using System.Linq;
class Kata
{
    public static string BalancedNumber(int number)
    {
        //Do Some Magic
        string digits = number.ToString();
        if(digits.Length == 1){
            return "Balanced";
        }
        int size = int.IsOddInteger(digits.Length) ? (digits.Length-1)/2 : (digits.Length-2)/2; 
        return digits.Take(size).Sum(x=>char.GetNumericValue(x)) == digits.TakeLast(size).Sum(x=>char.GetNumericValue(x)) ? "Balanced" : "Not Balanced";

        // Alternative
        // return $"{n}".Take(($"{n}".Length + 1) / 2 - 1).Sum(c => c) == $"{n}".Skip($"{n}".Length / 2 + 1).Sum(c => c)
        // ? "Balanced"
        // : "Not Balanced";
    }

    public static void Main(){
        Console.WriteLine(BalancedNumber(1024));
        Console.WriteLine(BalancedNumber(424));
    }
}