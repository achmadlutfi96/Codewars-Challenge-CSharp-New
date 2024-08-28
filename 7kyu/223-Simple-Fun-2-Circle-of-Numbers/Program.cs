namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public static int CircleOfNumbers(int n, int FirstNumber){
          //coding and coding..
          
          return n/2 > FirstNumber ? n/2+FirstNumber : FirstNumber-n/2; 
        }

        public static void Main(){
            Console.WriteLine(CircleOfNumbers(10,2));
            Console.WriteLine(CircleOfNumbers(10,7));
            Console.WriteLine(CircleOfNumbers(4,1));
            Console.WriteLine(CircleOfNumbers(6,3));
        }
    }
}