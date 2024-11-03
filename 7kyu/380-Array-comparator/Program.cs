using System.Linq;
public class Kata
{
    public static int MatchArrays(int[] v, int[] r)
    {
        return v.Intersect(r).Count();

        // Alternative
        // return r.Count(v.Contains);
    }

    public static void Main()
    {
        Console.WriteLine(MatchArrays(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 6 }));
    }
}