using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static List<int> Odds(List<int> values) =>
      // arrow it
      values.Where(v => v%2 == 1)
            .ToList();

    public static void Main(){
        foreach (var item in Odds(new List<int> {1, 2, 3, 4, 5, 6}))
        {
            Console.WriteLine(item);
        }
        
    }
}