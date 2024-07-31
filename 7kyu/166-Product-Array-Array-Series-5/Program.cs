using System.Linq;
class Kata
{
    public static int[] ProductArray(int[] array)
    {
        //Do Some Magic
        return array.Select((x, i) => array.Where((a, b) => b != i).Aggregate((x, y) => x * y)).ToArray();

        // Alternative 1
        // return array.Select(i => array.Aggregate((x, y) => x * y) / i).ToArray();
        // Alternative 2
        // var product = array.Aggregate((x,y) => x*y);
        // return array.Select(x => product / x).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", ProductArray(new int[] { 1, 5, 2 })));
    }
}