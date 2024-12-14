public class Kata
{
    static int gcd(int a, int b)
    {
        if (a == 0)
            return b;
        return gcd(b % a, a);
    }

    // method to return 
    // LCM of two numbers
    static int LeastCommonMultiple(int a, int b)
    {
        if (a == 0 && b == 0)
        {
            return 0;
        }
        if (a == 1 && b == 1)
        {
            return 1;
        }
        return (a / gcd(a, b)) * b;
    }
    public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
    {
        int[] products = pairs.Select(x => x[0] * x[1]).ToArray();
        int[] lcms = pairs.Select(x => LeastCommonMultiple(x[0], x[1])).ToArray();
        return products.Select((v, i) => v - lcms[i]).Sum();
    }


    // Alternative
    // static int gcd(int a, int b)
    // {
    //     if (a == 0) return b;
    //     if (b == 0) return a;
    //     return gcd(b, a % b);
    // }

    // static int lcm(int a, int b)
    // {
    //     if (a == 0 || b == 0) return 0;
    //     return a * b / gcd(a, b);
    // }

    // public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
    // {
    //     return pairs.Select(p => p[0] * p[1] - lcm(p[0], p[1])).Sum();
    // }

    public static void Main()
    {
        Console.WriteLine(SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 18 }, new int[] { 4, 5 }, new int[] { 12, 60 } }));
    }
}