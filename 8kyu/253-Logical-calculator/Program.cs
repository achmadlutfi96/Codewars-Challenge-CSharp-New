using System.Linq;
public class Kata
{
  public static bool LogicalCalc(bool[] array, string op)
  {
    return op switch{
        "AND" => array.Aggregate((v,n)=> v && n),
        "OR" => array.Aggregate((v,n)=> v || n),
        "XOR" => array.Aggregate((v,n) => v != n),
        _ => false
    };
  }

  public static void Main(){
    Console.WriteLine(LogicalCalc(new bool[] { true, true, true, false }, "AND"));
  }
}