// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq;
namespace Solution
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            return input.Select(i => -i).ToArray();
        }
        public static void Main()
        {
            foreach(var i in InvertValues(new int[] { -1, -2, -3, -4, -5 })){
                Console.WriteLine(i);
            }
        }
    }
}
