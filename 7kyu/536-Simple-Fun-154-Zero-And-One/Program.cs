namespace myjinxin
{
    using System;
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static int ZeroAndOne(string s)
        {
            //coding and coding..
            int cnt = 0;
            s+=" ";
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == '0' && s[i + 1] == '1') || (s[i] == '1' && s[i + 1] == '0')) i++;
                else cnt++;
            }
            return cnt-1;

            // Alternative 1
            // return Regex.Replace(s, "10|01", "").Length;

            // Alternative 2
            // return s.Replace("10", " ").Replace("01", " ").Length;
        }

        public static void Main()
        {
            Console.WriteLine(ZeroAndOne("01010"));
            Console.WriteLine(ZeroAndOne("11101111"));
        }
    }
}