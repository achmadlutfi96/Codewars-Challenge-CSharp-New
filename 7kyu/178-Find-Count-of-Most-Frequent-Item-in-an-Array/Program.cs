public class Kata
{
    public static int MostFrequentItemCount(int[] collection)
    {
        // Do your magic. :)
        return collection.Length > 0 ?collection.Distinct().Select(x=>collection.Count(y=>x==y)).Max() : 0;

        // Alternative
        // return collection.Any() ? collection.GroupBy(i => i).Max(g => g.Count()) : 0;
    }

    public static void Main()
    {
        Console.WriteLine(MostFrequentItemCount(new int[] {3, -1, -1}));
    }
}