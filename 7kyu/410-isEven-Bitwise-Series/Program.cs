public static class Kata
{
    public static bool IsEven(int n)
    {
        return n == Math.Round((double)n/2)*2;

        // Alternative
        // return (n & 1) == 0;

    }
}