using System;
using System.Linq;

public class Kata
{
    public static Counter GetCount(object word)
    {
        if (!word.GetType().Equals(typeof(string)))
        {
            return new Counter(0, 0);
        }
        int vowels = word.ToString().ToLower().Where("aiueo".Contains).Count();
        int consonants = word.ToString().Where(char.IsLetter).Count() - vowels;
        return new Counter(vowels, consonants);

        // Alternative
        // var s = (word as string ?? "").ToLower().Where(char.IsLetter).ToArray();
        // return new Counter(s.Count("aeiou".Contains), s.Count(c => !"aeiou".Contains(c)));
    }
}

public class Counter
{
    public int Vowels { get; }
    public int Consonants { get; }

    public Counter(int vowels, int consonants)
    {
        this.Vowels = vowels;
        this.Consonants = consonants;
    }
}