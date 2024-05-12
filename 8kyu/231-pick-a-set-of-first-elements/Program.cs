using System.Linq;
public class Kata
{
  public static object[] TakeFirstElements(object[] array, int n = 1)
  {
    return array.Take(n).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",",TakeFirstElements(new object[] { 'a', 'b', 'c', 'd', 'e' }, 2)));
  }
}