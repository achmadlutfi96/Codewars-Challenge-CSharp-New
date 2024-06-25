using System.Linq;
public class NoOddities
{
    public static int[] NoOdds(int[] values) 
    {
        // Code??
        return values.Where(x=>x%2 == 0).ToArray();
    }

    public static void Main(){
        foreach(var i in NoOdds(new int[]{1,2,3,4,5})){
            Console.WriteLine(i.ToString());
        }
    }
}