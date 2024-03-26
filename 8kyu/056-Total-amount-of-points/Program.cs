// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq;
using System;

public static class Kata {
    public static int TotalPoints(string[] games) {
        // insert magic here
        int res = 0;
        foreach (var s in games)
        {
            string[] i = s.Split(':').ToArray();
            int a = Convert.ToInt32(i[0]);
            int b = Convert.ToInt32(i[1]);
            if(a > b){
                res += 3;
            }else if(a < b){
                res += 0;
            }else{
                res += 1;
            }
        }
        return res;

        // Alternative
        // return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
    }
    public static void Main(){
        Console.WriteLine(TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }));
    }
}
