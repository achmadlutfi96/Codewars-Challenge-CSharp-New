namespace myjinxin
{
    using System;

    public class Kata
    {
        public static int Rounders(int Value)
        {
            //coding and coding..
            int res = Value;
            for (int i = 1; i < Value.ToString().Length; i++)
            {
                res = (int)(Math.Round(res/Math.Pow(10,i), MidpointRounding.AwayFromZero) * Math.Pow(10,i));
            }
            return res;
        }

        public static void Main()
        {
            Console.WriteLine(Rounders(15));
            Console.WriteLine(Rounders(1234));
            Console.WriteLine(Rounders(1445));
        }
    }
}