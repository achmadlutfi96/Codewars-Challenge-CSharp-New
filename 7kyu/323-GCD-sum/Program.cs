using System;

public class GCDsum
{
    public static (int,int) solve (int s, int g){         
         //..
         return s%g == 0 ? (g, s-g): (-1,-1);
    }

    public static void Main(){
        Console.WriteLine(solve(10,2));
    }        
}