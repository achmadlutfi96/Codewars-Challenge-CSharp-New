using System;
public static class MrSquare {
    public static bool FitSquares(int a, int b, int m, int n) {
        // You may code here
        return (a+b) <= Math.Max(m,n)  && Math.Max(a,b) <= Math.Min(m,n);

        // Alternative
        // returm Math.Max(m,n) >= a+b && Math.Max(a,b) <= Math.Min(m,n);
    }

    public static void Main(){
        Console.WriteLine(FitSquares(1, 2, 3, 2));
        Console.WriteLine(FitSquares(1, 2, 2, 1));
    }
}