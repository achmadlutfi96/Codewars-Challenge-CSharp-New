using System.Linq;

class Solution
{
    public static int Stray(int[] numbers)
    {
        
        foreach (var item in numbers.Distinct())
        {
            if (numbers.Where(i => i==item).Count() == 1){
                return item;
            }
        }
        return 0;

        // Alternative
        // return numbers.First(x => numbers.Count(i => i == x) == 1);
    }

    public static void Main()
    {
        Console.WriteLine(Stray(new int[] { 1, 1, 2 }));
    }
}