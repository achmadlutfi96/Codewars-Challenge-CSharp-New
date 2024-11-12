namespace myjinxin
{
    using System;
    using System.Linq;
    public class Kata
    {
        public static int Testit(int n){
        //   return n.ToString("b").Where(x=>x=='1').Count();
            return Convert.ToString(n, 2).Where(x=>x=='1').Count();
        }

        public static void Main()
        {
            Console.WriteLine(Testit(0));
            Console.WriteLine(Testit(1));
            Console.WriteLine(Testit(2));
            Console.WriteLine(Testit(3));
            Console.WriteLine(Testit(4));
            Console.WriteLine(Testit(5));
            Console.WriteLine(Testit(6));
            Console.WriteLine(Testit(7));
            Console.WriteLine(Testit(8));
            Console.WriteLine(Testit(9));
            Console.WriteLine(Testit(10));
            Console.WriteLine(Testit(100));
        }
    }
}