using System.Linq;
namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public static int[] Testit(int[] a, int[] b){
          return a.Distinct().Concat(b.Distinct()).OrderBy(x=>x).ToArray();
        }

        public static void Main(){
            Console.WriteLine(string.Join(",", Testit(new int[]{1,2},new int[]{1,2})));
        }
    }
}