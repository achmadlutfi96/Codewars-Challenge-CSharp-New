public class Kata
{
  public static string DuckDuckGoose(Player[] players, int goose)
  {
    //Enter code here
    return players[(goose-1)%players.Length].Name;
  }

  public static void Main(){
    var exampleNames = new string[] {"a", "b", "c", "d", "c", "e", "f", "g", "h", "z"};
    var players = exampleNames.Select(x=>new Player(x)).ToArray();
    Console.WriteLine(DuckDuckGoose(players,10));
  }
}
public class Player 
{
  public string Name {get;set;}
  
  public Player (string name) 
  {
	  this.Name = name;
  }
}