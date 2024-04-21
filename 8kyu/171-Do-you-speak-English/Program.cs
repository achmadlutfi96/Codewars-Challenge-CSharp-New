using System;
using System.Text.RegularExpressions;
namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {
            // Good luck!;
            return sentence.ToLower().Contains("english");

            // Alternative 1
            // sentence.Contains("english", System.StringComparison.CurrentCultureIgnoreCase);

            // Alternative 2
            // return Regex.IsMatch(sentence, "(?i)english");
        }

        public static void Main(){
            Console.WriteLine(SpeakEnglish("I speak English"));
            Console.WriteLine(SpeakEnglish("I speak English"));
        }
    }
}