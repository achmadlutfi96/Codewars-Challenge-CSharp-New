using System;

public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        //Your code
        return new int[] { 2*(w*h+w*d+h*d), w*h*d};
    }

    public static void Main(){
        foreach (var item in Get_size(4, 2, 6))
        {
            Console.WriteLine(item.ToString());
        }
    }
}