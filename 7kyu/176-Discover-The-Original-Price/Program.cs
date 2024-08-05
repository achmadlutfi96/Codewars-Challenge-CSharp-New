using System;

public static class Kata
{
    public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
    {
        //TODO: Some code here!
        return Math.Round(100M*discountedPrice/(100M-salePercentage), 2);
    }

    public static void Main(){
        Console.WriteLine(DiscoverOriginalPrice(75M,25M));
    }
}