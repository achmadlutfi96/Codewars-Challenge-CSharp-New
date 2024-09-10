using System.Linq;
public class Kata
{
  public static string[] SortMe(string[] names)
  {
    return names.OrderBy(x=>x).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", SortMe(new [] {"one", "two", "three"})));
  }
}