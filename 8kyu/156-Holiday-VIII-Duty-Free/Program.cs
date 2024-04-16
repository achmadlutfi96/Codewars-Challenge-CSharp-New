public class Kata
{
    public static int DutyFree(int normPrice, int Discount, int hol)
    {
        double d =(double) Discount/100;
        double p = normPrice * d;
        return (int) Math.Floor(hol/p);

        // Alternative
        // return (int)(hol / (normPrice * (Discount / 100f)));
    }

    public static void Main()
    {
        Console.WriteLine(DutyFree(12, 50, 1000));
        Console.WriteLine(DutyFree(17, 10, 500));
        Console.WriteLine(DutyFree(24, 35, 3000));
    }
}