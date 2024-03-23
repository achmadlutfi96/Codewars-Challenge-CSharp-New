// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
public class Kata
{
    public static bool Check(object[] a, object x)
    {
        return a.Contains(x);
    }
    public static void Main()
    {
        Console.WriteLine(Check(new object[] { 66, 101 }, 66));
    }
}
