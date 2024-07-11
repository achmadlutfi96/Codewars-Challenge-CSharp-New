using System;
class Kata
{
    public static string Automorphic(int n)
    {
        //Do Some Magic
        return Math.Pow(n,2).ToString().EndsWith(n.ToString()) ? "Automorphic" : "Not!!" ;
    }

    static void Main(){
        Console.WriteLine(Automorphic(25));
    }
}