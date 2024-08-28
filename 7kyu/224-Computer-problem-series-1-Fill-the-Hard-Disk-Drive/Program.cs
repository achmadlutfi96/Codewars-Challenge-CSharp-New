using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int Save(int[] sizes, int hd)
  {
    //Write your code here
    Stack<int> results = new Stack<int>(sizes);
    while(results.Sum() > hd){
        results.Pop();
    }
    return results.Count();

    // Alternative
    // return sizes.Where((x, i) => sizes.Take(i + 1).Sum() <= hd).Count();
  }

  public static void Main(){
    Console.WriteLine(Save(new int[]{4,4,4,3,3}, 12));
  }
}