using System.Linq;
class Kata
{
    public static int MaxTriSum(int[] a)
    {
        //Do Some Magic
        return a.Distinct().OrderBy(x => x).TakeLast(3).Sum();
    }

   public static void Main(){
        Console.WriteLine(MaxTriSum(new int[]{3, 2, 6, 8, 2, 3}));
    }
}