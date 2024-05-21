using System;
public class Slope
{

    public String slope(int[] points)
    {
        return (points[2]-points[0]) == 0 ? "undefined" : $"{(points[3]-points[1])/(points[2]-points[0])}";
    }

}

public class Program{
    public static void Main(){
        Slope s = new Slope();
        Console.WriteLine(s.slope(new int[]{19,3,20,3}));
    }
}
