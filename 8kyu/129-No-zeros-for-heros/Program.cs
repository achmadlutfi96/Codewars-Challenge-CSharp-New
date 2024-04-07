using System;

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
    {
        // your code
        // return (n == 0) ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
        while(n%10 == 0 && n != 0){
            n/=10;
        }
        return n;
    }
    public static void Main(){
        Console.WriteLine(NoBoringZeros(960000));
    }
}