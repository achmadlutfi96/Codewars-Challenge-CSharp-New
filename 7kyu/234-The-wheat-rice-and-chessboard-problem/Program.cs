using System;
class Kata
{
    public static int SquaresNeeded(long grains)
    {
        // int res = 0;
        // while(res*2 <= grains){
        //     res++;
        // }
        // return res;

        int res = 0;
        while(grains > 0){
            grains/=2;
            res++;
        }

        return res;

        // Alternative
        // return grains > 0 ? 1 + SquaresNeeded(grains/2) : 0;
    }

    public static void Main(){
        Console.WriteLine(SquaresNeeded(4));
    }
}