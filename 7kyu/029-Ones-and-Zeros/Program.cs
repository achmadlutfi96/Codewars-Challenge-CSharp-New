using System;
using System.Linq;
namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          //Code here
          return Convert.ToInt32(string.Concat(BinaryArray), 2);

          // Alternative
          // return BinaryArray.Aggregate((value, bit) => (value << 1) | bit);
        }

        public static void Main(string[] args){
            Console.WriteLine(binaryArrayToNumber(new int[] {0,1,1,0}));
        }
    }
}