public class Kata
{
  public static bool Xor(bool a, bool b)
  {
    return a != b;
    // Alternative
    // return a ^ b // bitwise operator XOR
  }
  public static void Main(string[] args){
    Console.WriteLine(Xor(false, false));
  }
}