namespace SeriesKata
{
    using System;
    using System.Linq;

    public class Series
    {

        public static int[] CompleteSeries(int[] arr)
        {
            return arr.Distinct().Count() == arr.Length ? Enumerable.Range(0, arr.Max()+1).ToArray() : new int[] {0};

            // Alternative
            // return Enumerable.Range(0, arr.Distinct().SequenceEqual(arr) ? arr.Max() + 1 : 1).ToArray();
        }

        public static void Main()
        {
            Console.WriteLine(string.Join(", ",CompleteSeries([2,1])));
        }
    }
}