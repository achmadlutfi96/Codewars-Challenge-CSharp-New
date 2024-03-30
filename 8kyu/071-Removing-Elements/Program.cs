// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;

public static class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        // happy coding
        return arr.Where((obj, index)=> index%2 == 0).ToArray();
    }
    public static void Main(){
        foreach (var item in RemoveEveryOther(new object[]{"Hello", "Goodbye", "Hello Again"}))
        {
            Console.WriteLine(item);
        }
        
    }
}
