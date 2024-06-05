using System;
using System.Linq;
public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		//Code here...
        Array.Sort(numbers);
        return numbers[0]+numbers[1];

        // Alternative
        // return numbers.OrderBy(i => i).Take(2).Sum();
	}

    public static void Main(){
        Console.WriteLine(sumTwoSmallestNumbers(new int[]{5, 8, 12, 19, 22}));
    }
}