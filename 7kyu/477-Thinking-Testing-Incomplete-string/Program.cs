namespace myjinxin
{
    using System;
    using System.Text;
    public class Kata
    {
        public static string Testit(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < s.Length; i += 2)
            {
                sb.Append((char)((s[i] + s[i - 1]) / 2));
            }
            return sb.ToString() + (s.Length % 2 == 1 ? s[s.Length - 1] : "");

            // Alternative
            // return Replace(s, "..", m => $"{(char)((m.Value[0] + m.Value[1]) / 2)}");

            // Alternative 2
            // return s.Length < 2 ? s :
        //   string.Concat((char)((s[0] + s[1]) / 2), Testit(s.Substring(2)));
        }

        public static void Main()
        {
            Console.WriteLine(Testit("aaaa"));
        }
    }


}



