// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
public static class Kata
{
  public static int ArrayPlusArray(int[] arr1, int[] arr2)
  {
    return arr1.Sum()+arr2.Sum();
  }
  public static void Main(){
    Console.WriteLine(ArrayPlusArray(new int[]{1,2,3}, new int[]{4,5,6}));
  }
}