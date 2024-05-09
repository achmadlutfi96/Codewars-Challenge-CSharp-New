public class Kata
{
  public static string UefaEuro2016(string[] teams, int[] scores)
  {
    return scores[0] == scores[1] ? $"At match {teams[0]} - {teams[1]}, teams played draw." : scores[0] > scores[1] ? $"At match {teams[0]} - {teams[1]}, {teams[0]} won!" : $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
  }

  public static void Main(){
    Console.WriteLine(UefaEuro2016(new [] { "Belgium", "Italy"}, new [] { 0, 2 }));
  }
}