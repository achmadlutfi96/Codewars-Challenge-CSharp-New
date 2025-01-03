namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        public string ShortForm(string str)
        {
            // do something
            return string.Concat(str.Where((v, i) => !"aeiou".Contains(char.ToLower(v)) || i == 0 || i == str.Length - 1));

            //   Alternative
            // return Regex.Replace(str,@"(?!^)[aeiouAEIOU](?!$)","");
        }
    }
}