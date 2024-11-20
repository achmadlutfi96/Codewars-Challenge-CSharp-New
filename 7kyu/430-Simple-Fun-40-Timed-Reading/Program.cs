namespace myjinxin
{
    using System;

    public class Kata
    {
        public static int TimedReading(int MaxLength, string text)
        {
            //coding and coding..
            text = string.Concat(text.Where(x => char.IsLetter(x) || x == ' '));
            return text.Equals(" ") || text.Equals("") ? 0 : text.Split(" ").Count(x => x.Length <= MaxLength);

            //   Alternative 1
            // string[] separators = {" ",",",".","!","\'","?","\""};
            //   return text.Split(separators,StringSplitOptions.RemoveEmptyEntries)
            //         .ToArray()
            //         .Where(x=>x.Length<=maxLength)
            //         .Count();

            // Alternative 2
            // return Regex.Replace(text, @"[;,\.\?\!']","").Split(' ').Count(w => w.Any() && w.Length <= MaxLength);  
        }

        public static void Main()
        {
            Console.WriteLine(TimedReading(4, "The Fox asked the stork, 'How is the soup?'"));
            Console.WriteLine(TimedReading(1, "..."));
            // Console.WriteLine(TimedReading(1,"Oh!"));
        }
    }
}