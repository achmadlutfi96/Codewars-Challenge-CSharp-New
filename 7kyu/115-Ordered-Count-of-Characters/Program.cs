using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution {
    public class Kata {
        public static List<Tuple<char, int>> OrderedCount(string input) {
            // Implement me!
            return input.Distinct().Select(x=>new Tuple<char, int>(x, input.Where(i=>i==x).Count())).ToList();

            // Alternative 1
            // return input
            //    .GroupBy(x => x)
            //    .Select(x => Tuple.Create(x.Key, x.Count()))
            //    .ToList();

            // Alternative 2
            // return input.GroupBy(x => x, (c, g) => (c, g.Count()).ToTuple());
        }

        public static void Main(){
            foreach (var items in OrderedCount("abracadabra"))
            {
                Console.WriteLine($"{items.Item1}-{items.Item2}");
            }
        }
    }
}