using System;
using System.Collections.Generic;

static class Kata 
{
    public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
    {
        List<IEnumerable<int>> res = new List<IEnumerable<int>>();
        if(list.Length < n){
            return res;
        }
        for(int i = 0; i <= list.Length-n ; i++){
            List<int> num = new List<int>();
            for(int j = i; j < (i+n) ; j++){
                num.Add(list[j]);
            }
            res.Add(num);
        }
        return res;

        // Alternative
        // return Enumerable.Range(0, Math.Max(0, list.Length - n + 1)).Select(x => list[x..(x + n)]);
    }
    public static void Main(){
        Console.WriteLine(EachCons(new[] {3, 5, 8, 13}, 2));
    }
}