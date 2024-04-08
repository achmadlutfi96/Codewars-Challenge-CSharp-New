using System.Linq;
public class Kata
{
  public static string[] AddLength(string str)
  {
    // TODO
    return str.Split(' ').Select(s=>$"{s} {s.Length}").ToArray();
  }
  public static void Main(){
    foreach (var item in AddLength("apple ban"))
    {
        Console.WriteLine(item);
    }
  }
}