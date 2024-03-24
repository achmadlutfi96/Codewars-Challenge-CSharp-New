// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Kata
{
    public static string Bmi(double weight, double height)
    {
        double res = weight/Math.Pow(height,2);
        if(res <= 18.5){
            return "Underweight";
        }else if(res <= 25.0){
            return "Normal";
        }else if(res <= 30.0){
            return "Overweight";
        }else{
            return "Obese";
        }
    }
    public static void Main()
    {
        Console.WriteLine(Bmi(80, 1.80));
    }
}
