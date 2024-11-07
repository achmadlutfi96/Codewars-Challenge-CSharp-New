using System.Linq;
public class Kata
{
    public static int MaxProduct(int[] array)
    {
        Array.Sort(array);
        return array[array.Length - 1] * array[array.Length-2];

        // Alternative
        // return array.OrderBy(x => -x).Take(2).Aggregate((a, b) => a * b);
    }

    public static void Main()
    {
        Console.WriteLine(MaxProduct(new int[] { 56, 335, 195, 443, 6, 494, 252 }));
    }
}