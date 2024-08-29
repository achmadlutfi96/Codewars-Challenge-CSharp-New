using System;
using System.Collections.Generic;

public static class Kata
{
    public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
    {
        // throw new NotImplementedException();
        return string.Join(",", hash.Select(x=>$"{x.Key} = {x.Value}"));
    }

    public static void Main()
    {
        Console.WriteLine(StringifyDict(new Dictionary<char, int> {{'a', 1}, {'b', 2}}));
    }
}