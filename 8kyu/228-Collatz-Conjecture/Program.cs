public class Kata
{
    public static uint count = 0;
    public static uint Hotpo(uint n)
    {
        if (n == 1)
        {
            uint temp = count;
            count = 0;
            return temp;
        }
        else
        {
            count++;
            return n % 2 == 0 ? Hotpo(n / 2) : Hotpo((3 * n) + 1);
        }

        // ALternative
        // return n == 1 ? 0 : n % 2 == 0 ? Hotpo(n / 2) + 1 : Hotpo(3 * n + 1) + 1;
    }

    public static void Main()
    {
        Console.WriteLine(Hotpo(23u));
    }
}