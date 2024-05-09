using System.Linq;
public class Kata
{
  public static int UniTotal(string str)
  {
    // total up dem unicodes!
    return str.Sum(x =>(int) x);
  }

  public static void Main(){
    Console.WriteLine(UniTotal("aaa"));
  }
}