public static class Kata {
    public static bool IsNegativeZero(double n) {
        return n.ToString().Equals("-0");

        // Alternative 1
        // return 1 / n == 1 / -0.0;
        // Alternative 2
        // return double.IsNegative(n) && n == 0.0;
    }

    public static void Main(){
        Console.WriteLine(IsNegativeZero(-0.0));
        Console.WriteLine(IsNegativeZero(0.0));
    }
}
