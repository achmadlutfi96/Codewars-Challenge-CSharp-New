using System;

public class Solution
{
    public static long solve(String st, int k)
    {
        //..
        long res = 0L;
        int n = st.Length - k;
        for (int i = 0; i < st.Length-n+1; ++i){
            string a = st.Substring(i,n);
            res = Math.Max(res,Convert.ToInt64(a));
        }
        return res;

        // Alternative
        // return Enumerable.Range(0, k + 1).Max(i => long.Parse(string.Concat(st.Skip(i).Take(st.Length - k))));
    }

    public static void Main()
    {
        Console.WriteLine(solve("123", 1));
        Console.WriteLine(solve("1234", 1));
    }
}