namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public static int MissingValues(int[] arr)
        {
            //coding and coding..
            int n1 = arr.Distinct().Where(x => arr.Where(y => x == y).Count() == 1).First();
            int n2 = arr.Distinct().Where(x => arr.Where(y => x == y).Count() == 2).First();
            return n1 * n1 * n2;

            // Alternative 1
            //  return arr.GroupBy(i => i).Where(g => g.Count() < 3)
            //      .Select(x => (int) Math.Pow(x.Key, 3 - x.Count()))
            //      .Aggregate((x, y) => x * y);

            // Alternative 2
            // var grouped = arr.GroupBy(i => i);
            // var x = grouped.FirstOrDefault(g => g.Count() == 1).Key;
            // var y = grouped.FirstOrDefault(g => g.Count() == 2).Key;
            // return x * x * y;
        }

        public static void Main()
        {
            Console.WriteLine(MissingValues(new int[] { 96, 56, 24, 46, 75, 46, 75, 21, 46, 21, 75, 96, 56, 96, 56 }));
        }
    }
}