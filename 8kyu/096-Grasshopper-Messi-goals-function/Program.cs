// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
  {
    // code goes here
    return laLigaGoals+copaDelReyGoals+championsLeagueGoals;
  }
  public static void Main(){
    Console.WriteLine(GetGoals(43,10,5));
  }
}
