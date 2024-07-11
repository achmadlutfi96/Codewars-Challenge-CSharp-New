using System.Linq;
class Kata
{
    public static int NthSmallest(int[] arr, int pos)
    {
        //Do Some Magic
        return arr.OrderBy(x => x).ElementAt(pos-1);
    }

    public static void Main(){
        Console.WriteLine(NthSmallest([3,1,2], 2));
    }
}