namespace azarias{
public static class Solution
{
  public static string Covfefe(string tweet)
  {
    // covfefe
    return tweet.Contains("coverage") ? tweet.Replace("coverage", "covfefe") : $"{tweet} covfefe";
  }

  public static void Main(){
    Console.WriteLine(Covfefe("nothing"));
    Console.WriteLine(Covfefe("coverage coverage"));
  }
}
}