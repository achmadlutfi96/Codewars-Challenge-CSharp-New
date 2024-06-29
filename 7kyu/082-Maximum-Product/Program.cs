using System;
using System.Linq;

public class Kata
{
    public static int AdjacentElementsProduct(int[] array)
    {
        //Do Some Magic
        int[] products = new int[array.Length-1];
        for (int i = 0; i < products.Length ; i++){
            products[i] = array[i] * array[i+1];
        }
        return products.Max();

        // Alternative
        // return array.Skip(1).Zip(array, (x, y) => x * y).Max();
    }

    public static void Main(){
        Console.WriteLine(AdjacentElementsProduct(new int[]{1, 2, 3}));
    }
}