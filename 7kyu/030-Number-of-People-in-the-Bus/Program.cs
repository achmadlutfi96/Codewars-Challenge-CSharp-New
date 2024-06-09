using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        // Happy Coding
        int p = 0;
        foreach (var i in peopleListInOut)
        {
            p+=i[0];
            p-=i[1];
        }
        return p;

        // Alternative
        // return peopleListInOut.Sum(Item => Item[0] - Item[1]);
    }
    public static void Main(){
        Console.WriteLine(Number(new List<int[]>(){new []{10,0},new []{3,5}, new []{5,8}}));
    }
}