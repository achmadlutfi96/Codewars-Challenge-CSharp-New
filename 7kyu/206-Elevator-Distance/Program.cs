using System;

public static class Kata
{
    public static int ElevatorDistance(int[] array) 
    {
        // your code here ..
        int res = 0;
        for (int i = 1; i < array.Length ; i++){
            res += Math.Abs(array[i]-array[i-1]);
        }
        return res;

        // Alternative 
        // return array.Skip(1).Select((x, i) => Math.Abs(x - array[i])).Sum();
    }

    public static void Main(){
        Console.WriteLine(ElevatorDistance(new[]{7,1,7,1}));
    }
}