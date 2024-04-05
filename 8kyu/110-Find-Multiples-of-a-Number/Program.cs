using System.Collections.Generic;

public class Kata
{
    public static List<int> FindMultiples(int integer, int limit)
    {
        // Your code here!
        
        List<int> res = new List<int>();
        foreach (var item in Enumerable.Range(1, limit))
        {
            if(item%integer == 0){
                res.Add(item);
            }
        }
        return res;

        // ALTERNATIVE
        // Enumerable.Range(1, limit / num).Select(x => x * num).ToList();
    }
    public static void Main()
    {
        foreach (var item in FindMultiples(5, 25))
        {
            Console.WriteLine(item);
        }
    }
}