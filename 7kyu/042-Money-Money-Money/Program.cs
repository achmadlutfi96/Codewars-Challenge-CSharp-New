using System;

public class Kata
{
    public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
    {
        int years = 0;
        while (principal < desiredPrincipal){
            double m = principal*interest;
            m -= m*tax;
            principal += m;
            years++;
        }
        return years;

        // Alternative
        //  return (int) Math.Ceiling(Math.Log(dp/p, 1+(i*(1-t))));
    }

    public static void Main(){
        Console.WriteLine(CalculateYears(1000,0.01625,0.18,1200));
    }
}