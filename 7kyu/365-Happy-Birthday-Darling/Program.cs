namespace Solution
{
    using System;

    public class Kata
    {
        public static string WomensAge(int n)
        {
            //Happy coding..
            int age = n%2 == 0 ? 20 : 21;
            return $"{n}? That's just {age}, in base {n/2}!";

            // Alternative
            // return $"{n}? That's just {20+n%2}, in base {n/2}!";
        }

        public static void Main()
        {
            Console.WriteLine(WomensAge(83));
        }
    }
}
