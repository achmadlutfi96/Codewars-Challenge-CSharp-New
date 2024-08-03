using System;
class Kata
{
    public static string JumpingNumber(int number)
    {
        //Do Some Magic
        string n = number.ToString();
        for (int i = 1; i < n.Length; i++)
        {
            if (Math.Abs(char.GetNumericValue(n[i]) - char.GetNumericValue(n[i - 1])) != 1)
            {
                return "Not!!";
            }
        }
        return "Jumping!!";

        // Alternative 1
        // return n < 10 ? "Jumping!!" : Math.Abs(n%10 - (n/10)%10) != 1 ? "Not!!" : JumpingNumber(n/10);
    }

    public static void Main()
    {
        Console.WriteLine(JumpingNumber(4343456));
    }
}