// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {   
        if(input == null){
            return new int[] {};
        }
        return input.Length != 0?new int[]{input.Count(i=>i > 0), input.Where(i => i < 0).Sum()}: new int[]{} ; //return an array with count of positives and sum of negatives
    }

    public static void Main(){
        foreach(var i in CountPositivesSumNegatives(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15})){
            Console.WriteLine(i);
        }
        foreach(var i in CountPositivesSumNegatives(null)){
            Console.WriteLine(i);
        }
    }
}
