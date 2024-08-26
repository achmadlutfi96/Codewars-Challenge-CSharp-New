using System;

public static class Kata
{
    public static bool DivisibleByThree(string n)
    {
        //     throw new NotImplementedException();

        return (n.Sum(x=>x) - (n.Sum(x=>x)/3*3)) == 0; 

        // Alternative
        // return BigInteger.Parse(n) % 3 == 0;
    }

    public static void Main()
    {
        Console.WriteLine(DivisibleByThree("1891009"));
        Console.WriteLine(DivisibleByThree("000009"));
    }
}