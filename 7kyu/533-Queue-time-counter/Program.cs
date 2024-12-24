using System;
using System.Linq;
class Kata
{
    public static int Queue(int[] queuers, int pos)
    {
        int i = 0;
        int res = 0;
        while(queuers[pos] > 0){
            if(queuers[i] > 0){
                queuers[i]--;
                res++;
            }
            i++;
            if(i == queuers.Length){
                i=0;
            }
        }
        return res;

        // Alternative 
        // return queuers.Select((x, i) => Math.Min(x, queuers[pos] + (i <= pos ? 0 : -1))).Sum();
    }

    public static void Main()
    {
        Console.WriteLine(Queue(new[] { 2, 5, 3, 6, 4 }, 0));
        Console.WriteLine(Queue(new[] { 2, 5, 3, 6, 4 }, 1));
    }
}