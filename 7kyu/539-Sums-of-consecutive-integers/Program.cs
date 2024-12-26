public class SumOfConsecutiveIntegers
{
    public static int Position(int x, int y, int n)
    {
        // TODO: return consecutive integer at requested position
        int a = (y - (x * (x - 1)) / 2) / x; 
        return a + n;

        // Alternative
        // return (2*y-x*x -x)/(2*x) + n+1;
    }

    public static void Main()
    {
        Console.WriteLine(Position(4,14,3));
    }
}