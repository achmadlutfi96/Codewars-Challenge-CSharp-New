using System;

namespace Solution
{
    public static class Program
    {
        public static int[] reverseList(int[] list)
        {
            Array.Reverse(list);
            return list;
        }

        public static void Main(){
            Console.WriteLine(string.Join(",", reverseList(new int[]{1,2,3})));
        }
    }
}