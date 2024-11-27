using System;

public static class Kata
{
    public static int Solution(int[] items, int index, int defaultValue)
    {
        // throw new NotImplementedException();
        if(index < 0){
            if(-items.Length > index){
                return defaultValue;
            }
            return items[items.Length+index];
        }

        return index < items.Length ? items[index] : defaultValue;

        // Alternative 
        // return items.Length >= Math.Abs(index)
        // ? index < 0 ? items[^Math.Abs(index)] : items[index]
        // : defaultValue;
    }

    public static void Main()
    {
        int[] range = Enumerable.Range(1, 3).ToArray();
        Console.WriteLine(2==Kata.Solution(range, 1, -1));
        Console.WriteLine(3 == Kata.Solution(range, -1, -1));
        Console.WriteLine(-1== Kata.Solution(range, -5, -1));
        Console.WriteLine(1==Kata.Solution(range, -3, -1));
    }
}