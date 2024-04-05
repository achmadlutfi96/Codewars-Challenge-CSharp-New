using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static List<int> ReverseList(List<int> list)
    {
        // Return a new list with its elements in reverse order compared to the input list
        // Do not mutate the original list!
        return list.Reverse<int>().ToList();
    }
    public static void Main()
    {
        foreach (var item in ReverseList(new List<int> { 4, 3, 2, 1 }))
        {
            Console.WriteLine();
        }
    }
}