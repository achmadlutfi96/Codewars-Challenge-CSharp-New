using System;
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if(a > 0 && b > 0 && c > 0){
            int[] n = [a,b,c];
            Array.Sort(n);
            return n[0]+n[1] > n[2];
        }else{
            return false;
        }

        // Alternative
        // return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    }

    public static void Main(){
        Console.WriteLine(IsTriangle(5, 7, 10));
    }
}