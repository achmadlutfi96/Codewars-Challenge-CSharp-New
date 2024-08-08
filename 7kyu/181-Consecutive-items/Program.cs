using System;
using System.Linq;

namespace Solution
{
    public static class Kata
    {
        public static bool Consecutive(int[] arr, int a, int b)
        {
            int indexA = Array.IndexOf(arr, a);
            int indexB = Array.IndexOf(arr, b);
            return indexA > 0 ? indexA-1 == indexB || indexA+1 == indexB : indexA+1 == indexB;

            // Alternative
            // return Math.Abs(Array.IndexOf(arr,a)- Array.IndexOf(arr, b)) == 1;
        }

        public static void Main()
        {
            Console.WriteLine(Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1));
            Console.WriteLine(Consecutive(new int[]{1, 6, 9, -3, 4, -78, 0}, -3, 4));
        }
    }
}