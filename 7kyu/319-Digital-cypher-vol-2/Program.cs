using System;
using System.Linq;
public class Kata
{
    public static string Decode(int[] code, int key)
    {
        int[] arrKey = key.ToString().Select(x=>(int)char.GetNumericValue(x)).ToArray();
        for (int i = 0;i < code.Length; i++){
            code[i] -= arrKey[i%arrKey.Length];
            code[i] = code[i]%27;
        }
        return string.Concat(code.Select(x=>Convert.ToChar(x+96)));

        // Alternative
        // return string.Concat(code.Select((x, i) => (char) (x - $"{key}"[i % $"{key}".Length] + 144)));
    }

    public static void Main()
    {
        Console.WriteLine(Decode(new int[] {20, 12, 18, 30, 21}, 1939));
    }
}
