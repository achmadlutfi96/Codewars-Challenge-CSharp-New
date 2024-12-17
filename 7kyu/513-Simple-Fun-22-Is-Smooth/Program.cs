namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public static bool IsSmooth(int[] arr){
          //coding and coding..
          int a = arr[0];
          int b = arr[arr.Length-1];
          int c = arr.Length % 2 == 0 ? arr[(arr.Length/2)-1]+arr[arr.Length/2] : arr[arr.Length/2]; 
          return a == b && b == c;

        //   Alternative
        // return arr[0] == arr[^1] && arr[((arr.Length - 1) / 2)..][..(arr.Length % 2 == 0 ? 2 : 1)].Sum() == arr[0];
        }

        public static void Main()
        {
            Console.WriteLine(IsSmooth(new int[]{7, 2, 2, 5, 10, 7}));
        }
    }
}