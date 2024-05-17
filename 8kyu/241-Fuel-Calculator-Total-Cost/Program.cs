using System;
public class Kata
{
  public static double FuelPrice(double litres, double pricePerLitre)
  {
    pricePerLitre = pricePerLitre * 100;
    double discountPerLitre = 0;
    if (litres >= 2) {
        double discount = 5 * Math.Floor(litres/2);
        discount = discount > 25 ? 25 : discount;
        discountPerLitre = discount * litres;
    }
    return Math.Round(((litres*pricePerLitre)-discountPerLitre)/100,2);

    // Alternative
    // return Math.Round(l * (p - Math.Min(0.25, 0.05 * Math.Floor(l / 2))), 2);
  }

  public static void Main(){
    Console.WriteLine(FuelPrice(5, 1.23));
  }
}