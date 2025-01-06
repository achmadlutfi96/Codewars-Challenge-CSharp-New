using System;
using System.Text.RegularExpressions;
public class Kata
{
    public static int CountZero(string s)
    {
        int cnt = 0;
        s = s.Replace("()", "0");
        foreach (char ch in s)
        {
            if ("abdegopq069DOPQR".Contains(ch.ToString())) cnt++;
            if ("%&B8".Contains(ch.ToString())) cnt += 2;
        }
        return cnt;
    }
}