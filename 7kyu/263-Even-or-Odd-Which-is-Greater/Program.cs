public class EvenOrOddKata
{
    public static string EvenOrOdd(string str)
    {
        // your code here
        double odd = str.Where(x => char.GetNumericValue(x) % 2 != 0).Sum(x => char.GetNumericValue(x));
        double even = str.Where(x => char.GetNumericValue(x) % 2 == 0).Sum(x => char.GetNumericValue(x));
        if (odd > even)
        {
            return "Odd is greater than Even";
        }
        else if (odd < even)
        {
            return "Even is greater than Odd";
        }
        else
        {
            return "Even and Odd are the same";
        }

        // Alternative 1
        // int [] strInts = str.Select(c => Convert.ToInt32(c.ToString())).ToArray();
        //   int sumOrSub = strInts.Sum(t => (t%2 == 0) ? t : -t);
        //   return (sumOrSub > 0) ? "Even is greater than Odd" :
        //          (sumOrSub < 0) ? "Odd is greater than Even" : "Even and Odd are the same";

        // Alternative 2
        // return new[] {"Odd is greater than Even", "Even and Odd are the same", "Even is greater than Odd"}[
        // str.Select(c => int.Parse(c.ToString())).Sum(i => i % 2 == 0 ? i : -i).CompareTo(0) + 1];
    }

    public static void Main()
    {
        Console.WriteLine(EvenOrOdd("123"));
    }
}