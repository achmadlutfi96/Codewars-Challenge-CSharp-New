using System;
using System.Linq;

namespace EvenTimesLast
{
	public static class Solver
	{
		public static int EvenTimesLast(int[] arr)
		{
            if(arr.Length == 0){
                return 0;
            }
			return arr.Where((v,i)=> i%2 == 0).Sum() * arr.Last();
		}

        public static void Main(){
            Console.WriteLine(EvenTimesLast(new int[] {2, 3, 4, 5}));
        }
	}
}