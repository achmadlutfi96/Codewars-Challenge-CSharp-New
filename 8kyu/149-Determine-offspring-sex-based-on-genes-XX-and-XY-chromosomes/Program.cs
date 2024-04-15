public class Kata
{
  public static string ChromosomeCheck(string sperm)
  {
    return sperm.Equals("XY") ? "Congratulations! You're going to have a son.": "Congratulations! You're going to have a daughter.";
  }

  public static void Main(){
    Console.WriteLine(ChromosomeCheck("XY"));
  }
}