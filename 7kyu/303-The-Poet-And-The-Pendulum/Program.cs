using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static int[] Pendulum(int[] values)
    {
        //Do Some Magic
        return values.OrderBy(x => x).Skip(1).Where((x,i)=>i%2==1).Reverse().Concat(new int[]{values.Min()}).Concat(values.OrderBy(x=>x).Skip(1).Where((x,i)=>i%2==0)).ToArray();

        // Alternative
        // return values
        //         .OrderBy(x => x)
        //         .Aggregate(Enumerable.Empty<int>(),(c, n) => c.Count() % 2 == 0 ? c.Prepend(n) : c.Append(n))
        //         .ToArray();
    }

    public static void Main(){
        Console.WriteLine(string.Join(",",Pendulum([6, 6, 8 ,5 ,10])));
    }
}