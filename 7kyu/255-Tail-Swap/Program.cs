using System;

public static class Kata
{
    public static string[] TailSwap(string[] arr)
    {
        // your code here
        string[] s1 = arr[0].Split(":");
        string[] s2 = arr[1].Split(":");
        return new string[] { string.Join(":", s1[0], s2[1]), string.Join(":", s2[0], s1[1]) };

        // Alternative 1
        // return arr.Select(x => x.Split(':')).Aggregate((a, b) => new[] { $"{a[0]}:{b[1]}", $"{b[0]}:{a[1]}" });

        // Alternative 2
        // new[]
        // {
        //     $"{arr[0].Split(":")[0]}:{arr[1].Split(":")[1]}",
        //     $"{arr[1].Split(":")[0]}:{arr[0].Split(":")[1]}"
        // };
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", TailSwap(new[] { "abc:123", "cde:456" })));
    }
}
