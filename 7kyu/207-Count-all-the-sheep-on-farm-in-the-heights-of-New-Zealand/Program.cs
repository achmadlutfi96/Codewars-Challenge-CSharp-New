using System.Linq;
namespace CodeWars
{
    public class Kata
    {
        public static int lostSheep(int[] friday, int[] saturday, int total)
        {
            // Code here
            return total - (friday.Sum() + saturday.Sum());

            // Alternative 
            // return total - friday.Concat(saturday).Sum();
        }

        public static void Main(){
            Console.WriteLine(lostSheep(new int[] { 1, 2 }, new int[] { 3, 4 }, 15));
        }
    }
}