namespace myjinxin
{
    using System;

    public class Kata
    {
        public bool IsInfiniteProcess(int a, int b)
        {
            //coding and coding..

            while (a != b)
            {
                a++;
                b--;

                if(a == 0 || b == 0 || a == 100 || b == 100) return true;
            }
            return false;

            // Alternative
            // return a>b || a<b && (b-a) % 2 == 1;
        }
    }
}