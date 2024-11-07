using System.Linq;
public class CandyProblem
{
    public static int GetMissingCandies(int[] candies)
    {
        //TODO: add your code here
        if (candies.Length < 2)
        {
            return -1;
        }
        return candies.Select(x => candies.Max() - x).Sum();

        // Alternative
        // if (candies.Length <= 1)
        // {
        //     return -1;
        // }

        // return candies.Max() * candies.Length - candies.Sum();
    }

    public static void Main()
    {
        Console.WriteLine(GetMissingCandies(new int[] { 5, 8, 6, 4 }));
    }
}