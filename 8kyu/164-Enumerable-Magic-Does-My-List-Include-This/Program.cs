using System.Linq;
public class Kata
{
  public static bool Include(int[] arr, int item)
  {
    return arr.Contains(item);
  }

  public static void Main(){
    Console.WriteLine(Include(new int[] { 1,2,3,4 }, 3));
  }
}