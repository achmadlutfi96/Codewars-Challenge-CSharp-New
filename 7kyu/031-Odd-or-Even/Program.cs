using System.Linq;
public class Kata
{
  public static string OddOrEven(int[] array)
  {
    //enter code here
    return array.Length > 0 ? array.Sum()%2 == 0 ? "even" : "odd" : "even";

    // Alternative
    // return array.Sum() % 2 == 0 ? "even" : "odd";
  }

  public static void Main(){
    Console.WriteLine(OddOrEven(new int[] {}));
  }
}