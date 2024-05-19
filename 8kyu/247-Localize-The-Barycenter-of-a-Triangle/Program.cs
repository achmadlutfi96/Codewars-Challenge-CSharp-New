using System;
public class Barycenter
{
    public static double[] BarTriang(double[] x, double[] y, double[] z)
    {
        // your code
        return new double[] { Math.Round((x[0]+y[0]+z[0])/3, 4), Math.Round((x[1]+y[1]+z[1])/3,4)};
    }

    public static void Main(){
        foreach (var item in BarTriang( new double[]{4,6}, new double[]{12,4}, new double[]{10,10}))
        {
            Console.WriteLine(item);
        }
        
    }
}