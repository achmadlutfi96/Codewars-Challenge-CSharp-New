using System.Linq;
public class Kata {
  public static int MaxProduct(int[] arr, int size) {
    // your code here
    return arr.OrderBy(x => x).TakeLast(size).Aggregate((a,b)=>a*b);
  }

  public static void Main(){
    Console.WriteLine(MaxProduct(new int[] { 4, 3, 5 }, 2));
  }
}