// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;


public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
    // throw new System.NotImplementedException();
    return Enumerable.Range(1, n).ToArray();
  }
  public static void Main(){
    foreach (var item in MonkeyCount(5))
    {
        Console.WriteLine(item);
    }
  }
}