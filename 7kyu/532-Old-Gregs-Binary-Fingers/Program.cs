using System;
using System.Linq;
public class BinaryFingers
{
  public static string[] GetFingers(string binary)
  {
    string[] fingers = new string[]{"Pinkie", "Ring", "Middle", "Index", "Thumb"};
    return binary.PadLeft(5,'0').Select((v,i)=>v=='1'?fingers[i] : null).Where(x=>x!=null).ToArray();

    // Alternative
    // return new[] { "Pinkie", "Ring", "Middle", "Index", "Thumb" }.Skip(5 - binary.Length)
        // .Where((_, i) => binary[i] == '1')
        // .ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(", ", GetFingers("101")));
    Console.WriteLine(string.Join(", ", GetFingers("11111")));
  }
}