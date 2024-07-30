public class Kata
{
  public static int[] WordValue(string[] a)
  {
    return a.Select((v,i)=>v.Select(x=>x!=' '?(int)x-96 : 0).Sum()*(i+1)).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", WordValue(new string[] {"codewars", "abc", "xyz"})));
  }
}