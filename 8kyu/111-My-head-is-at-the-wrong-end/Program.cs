using System.Linq;
public class Kata
{
  public static string[] FixTheMeerkat(string[] arr)
  {
    //your code here
    return arr.Reverse().ToArray();
  }
  public static void Main(){
    foreach (var item in FixTheMeerkat(new string[] {"tail", "body", "head"}))
    {
        Console.WriteLine(item);
    }
  }
}