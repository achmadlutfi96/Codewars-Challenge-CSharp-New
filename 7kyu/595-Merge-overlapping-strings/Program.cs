namespace Solution;

public class Kata
{
    public static string MergeStrings(string first, string second)
    {
        int maxOverlap = 0;
        int overlapIdx = 0;
        // Find the longest overlap 
        for (int i = 1; i <= Math.Min(first.Length, second.Length); i++)
        {
            if (first.Substring(first.Length - i) == second.Substring(0, i))
            {
                maxOverlap = i;
                overlapIdx = i;
            }
        } // Merge the strings with the maximum overlap 
        return first + second.Substring(overlapIdx);

        // Alternative
        // int overlapLength = 0;
        // int minLength = Math.Min(first.Length, second.Length);

        // for (int i = 1; i <= minLength; i++)
        // {
        //     if (first.EndsWith(second.Substring(0, i)))
        //     {
        //         overlapLength = i;
        //     }
        // }

        // return first + second.Substring(overlapLength);
    }

    public static void Main()
    {
        Console.WriteLine(MergeStrings("abc", "ab"));
        Console.WriteLine(MergeStrings("abcde", "cdefgh"));
    }
}