using System;
using System.Linq;

class Kata
{
    public static int SumOfMinimums(int[,] numbers)
    {
        // your code here 
        int result = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1)-1; j++)
            {
                
                for (int k = j+1; k < numbers.GetLength(1); k++)
                {
                    if (numbers[i, j] > numbers[i, k])
                    {
                        // (numbers[i,j], numbers[i,k]) = (numbers[i,k], numbers[i,j]);
                        int temp = numbers[i, j];
                        numbers[i, j] = numbers[i, k];
                        numbers[i, k] = temp;
                    }

                }

            }
        }

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            
            result += numbers[i, 0];
        }
        return result;

        // Alternative
        // return Enumerable.Range(0, n.GetLength(0)).Select(x => Enumerable.Range(0, n.GetLength(1)).Select(y => n[x,y])).Sum(x => x.Min());

    }

    public static void Main()
    {
        Console.WriteLine(SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }));
        Console.WriteLine(SumOfMinimums(new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } }));
        Console.WriteLine(SumOfMinimums(new int[4,4] { {11,12,14,54}, {67,89,90,56}, {7,9,4,3}, {9,8,6,7} }));
    }
}