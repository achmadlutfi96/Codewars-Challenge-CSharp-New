using System;

class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        // your code
        int n = 0;
        while(p0 < p){
            p0 += (int)(p0*(percent/100)) + aug;
            n++;
        }
        return n;

        // Alternative
        // return p0 >= p ? 0 : 1 + NbYear((int) (p0 + p0 * percent / 100 + aug), percent, aug, p);

    }

    public static void Main(){
        Console.WriteLine(NbYear(1500, 5, 100, 5000));
    }
}