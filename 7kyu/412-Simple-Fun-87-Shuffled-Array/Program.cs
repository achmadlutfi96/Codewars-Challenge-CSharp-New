namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static int[] ShuffledArray(int[] shuffled)
        {
            //coding and coding..
            int index = 0;
            for (int i = 0; i < shuffled.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < shuffled.Length; j++)
                {
                    if (i != j)
                    {
                        sum += shuffled[j];
                    }
                }
                if (sum == shuffled[i])
                {
                    index = i;
                    break;
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < shuffled.Length; i++)
            {
                if (index == i) { continue; }
                result.Add(shuffled[i]);
            }
            return result.OrderBy(x => x).ToArray();

            //  Alternative
            // return shuffled.Where((x, i) => i != Array.IndexOf(shuffled, shuffled.Sum() / 2)).OrderBy(x => x).ToArray(); 
        }

        public static void Main()
        {
            Console.WriteLine(string.Join(", ", ShuffledArray(new int[] { 1, -3, -5, 7, 2 })));
            Console.WriteLine(string.Join(", ", ShuffledArray(new int[] { 2, -1, 2, 2, -1 })));
        }
    }
}