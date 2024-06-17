using System.Linq;
public class LargestTwo
{
  public static int[] TwoOldestAges(int[] ages)
  {
    return ages.OrderBy(x=>x).TakeLast(2).ToArray();
  }

  public static void Main(){
    foreach (var item in TwoOldestAges(new[] {1,5,87,45,8,8}))
    {
        Console.WriteLine(item);     
    }
    
  }
}