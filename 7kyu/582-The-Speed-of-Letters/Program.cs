using System;
using System.Text;

class Kata
{
    public static string Speedify(string input)
    {
        StringBuilder result = new StringBuilder(new string(' ', 100 + 26)); // 100 for max input length, 26 for max shift 
        int length = input.Length;
        for (int i = 0; i < length; i++)
        {
            char letter = input[i]; int shift = letter - 'A'; // Calculate the shift based on the letter's position in the alphabet 
            int newIndex = i + shift; // Determine the new index after shifting 
            // Ensure we only place the latest character at each position 
            if (newIndex < result.Length)
            {
                result[newIndex] = letter;
            }
        }
        // Convert the StringBuilder to a string and trim any trailing spaces 
        return result.ToString().TrimEnd();

        // Alternative
        // var result = new string(' ', input.Length + 25).ToCharArray();
        // for (var i = 0; i < input.Length; ++i)
        // {
        //   result[input[i] - 65 + i] = input[i];
        // }

        // return new string(result).TrimEnd();
    }

    public static void Main()
    {
        Console.WriteLine(Speedify("HELLOWORLD"));
    }
}