// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
public class Kata
{
  public static int Min(int[] list)
  {
    return list.Min();
  }
  
  public static int Max(int[] list)
  {
    return list.Max();
  }

  public static void Main(){
    Console.WriteLine(Min(new []{-52, 56, 30, 29, -54, 0, -110}));
    Console.WriteLine(Max(new []{4,6,2,1,9,63,-134,566}));
  }
}
