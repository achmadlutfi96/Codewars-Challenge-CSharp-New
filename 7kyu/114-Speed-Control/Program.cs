using System;

public class GpsSpeed
{

    public static int Gps(int s, double[] x)
    {
        // your code
        if (x.Length < 2)
        {
            return 0;
        }
        double[] result = new double[x.Length - 1];
        for (int i = 0; i < x.Length - 1; i++)
        {
            double deltaDistance = x[i + 1] - x[i];
            result[i] = 3600 * deltaDistance / s;
        }
        return (int)result.Max();

        // Alternative 1
        // if(x.Length > 2)
        //   {
        //      var averageSpeeds = x.Skip(1).Select((distance, index) => ((distance - x[index]) / s) * 3600);
        //      return Convert.ToInt32(Math.Floor(averageSpeeds.Max()));
        //   }
        //   return 0;

        // Alternative 2
        // return (int) (x.Length < 2 ? 0 : x.Zip(x.Skip(1), (a, b) => b - a).Max() * 3600 / s);
    }

    public static void Main()
    {
        Console.WriteLine(Gps(20, new double[] { 0.0, 0.23, 0.46, 0.69, 0.92, 1.15, 1.38, 1.61 }));
    }
}