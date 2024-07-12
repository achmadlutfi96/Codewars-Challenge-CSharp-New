using System;
using System.Linq;
class Kata
{
    private static int Factorial(int n) => n == 0 ? 1 : n * Factorial(n - 1);
    public static string StrongNumber(int number)
    {
        //Do Some Magic
        return int.Parse(string.Concat(number.ToString().Select(x=>Enumerable.Range(1,(int)char.GetNumericValue(x)).Aggregate(1, (value, next)=>value*next)).Sum())) == number ? "STRONG!!!!" : "Not Strong !!";

        // Alternative
        // return number == number.ToString().Sum(n => Factorial(int.Parse(n.ToString())))
        //   ? "STRONG!!!!"
        //   : "Not Strong !!";
    }

    public static void Main(){
        Console.WriteLine(StrongNumber(145));
    }
}