using System.Collections;

public class Kata
{
  public static string MouthSize(string animal)
  {
    // code here
    return animal.ToLower().Equals("alligator") ? "small" : "wide";

    // Alternative
    // return animal.Equals("alligator", StringComparison.OrdinalIgnoreCase) ? "small" : "wide";
  }
  public static void Main(){
    Console.WriteLine(MouthSize("toucan"));
    Console.WriteLine(MouthSize("alligator"));
  }
}