namespace myjinxin
{
    using System;

    public class Kata
    {
        public static int[] FirstReverseTry(int[] arr)
        {
            //coding and coding..
            if (arr.Length < 2)
            {
                return arr;
            }
            int temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
            return arr;

            //   Alternative
            // return arr.Length > 1 ? arr[1..^1].Prepend(arr[^1]).Append(arr[0]).ToArray() : arr;
        }

        public static void Main()
        {
            Console.WriteLine(string.Join(", ", FirstReverseTry(new int[] { 23, 54, 12, 3, 4, 56, 23, 12, 5, 324 })));
        }
    }
}