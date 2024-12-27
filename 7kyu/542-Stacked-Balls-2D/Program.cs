using System;
public class Dinglemouse
{
    public static double StackHeight2d(int layers)
    {
        // Your code here!
        if (layers == 0) return 0; 
        return 1 * (1 + (layers - 1) * Math.Sqrt(3) / 2);

        // Alternative
        // return layers > 0 ? Math.Sqrt(3) / 2 * (layers - 1) + 1 : 0;
    }

    public static void Main()
    {
        Console.WriteLine(StackHeight2d(2));
    }
}