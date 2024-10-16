public class DryPotatoes
{

    public static int Potatoes(int p0, int w0, int p1)
    {
        // your code
        decimal a =(decimal) p0/100;
        decimal b =(decimal) a*w0;
        decimal c = w0-b;
        decimal d = (decimal)(100-p1)/100;
        int res = (int) (c/d);
        return res;

        // Alternative
        // return w0 * (100 - p0) / (100 - p1);
    }

    public static void Main()
    {
        Console.WriteLine(Potatoes(99, 100, 98));
        Console.WriteLine(Potatoes(82, 127, 80));
    }
}