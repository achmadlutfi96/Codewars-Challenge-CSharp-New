public static class BlueAndRedMarbles
{
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        // Code goes here..
        return(double) (blueStart - bluePulled) / ((blueStart - bluePulled) + (redStart - redPulled));
    }

    public static void Main()
    {
        Console.WriteLine(GuessBlue(5, 5, 2, 3));
        Console.WriteLine(GuessBlue(5, 7, 4, 3));
        Console.WriteLine(GuessBlue(12, 18, 4, 6));
    }
}