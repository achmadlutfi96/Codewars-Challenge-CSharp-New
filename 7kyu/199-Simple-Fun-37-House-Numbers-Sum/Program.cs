namespace myjinxin
{
    using System;

    public class Kata
    {
        public static int HouseNumbersSum(int[] inputArray)
        {
            //coding and coding..
            int res = 0;
            foreach (int i in inputArray)
            {
                if (i == 0)
                {
                    break;
                }
                res += i;
            }
            return res;

            // Alternative
            // return inputArray.TakeWhile(x => x != 0).Sum();
        }

        public static void Main()
        {
            Console.WriteLine(HouseNumbersSum(new int[] { 5, 1, 2, 3, 0, 1, 5, 0, 2 }));
            Console.WriteLine(HouseNumbersSum(new int[] { 4, 1, 2, 3, 0, 10, 2 }));
        }
    }
}