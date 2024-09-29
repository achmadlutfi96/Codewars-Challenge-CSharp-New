using System.Linq;
public class Kata
{
  public static string RakeGarden(string garden)
  {
    return string.Join(" ", garden.Split(" ").Select(x=>x.Equals("rock") || x.Equals("gravel") ? x : "gravel"));

    // Alternative 
    // return Regex.Replace(garden, @"\b(?!(rock|gravel)\b)\w+", "gravel");
  }

  public static void Main(){
    Console.WriteLine(RakeGarden("slug spider rock gravel gravel gravel gravel gravel gravel gravel"));
  }
}