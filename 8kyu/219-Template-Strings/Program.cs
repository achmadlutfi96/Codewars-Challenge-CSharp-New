public class Templates{
  public static string TempleStrings(string obj, string feature)
  {
      // show me the code!
      return $"{obj} are {feature}";
  }

  public static void Main(){
    Console.WriteLine(TempleStrings("Animals","Good"));
  }
}