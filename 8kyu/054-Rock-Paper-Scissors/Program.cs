// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static string Rps(string p1, string p2)
  {
    if((p1 == "rock" && p2 == "scissors") 
        || (p1 == "scissors" && p2 == "paper") 
        || (p1 == "paper" && p2 == "rock")){
            return "Player 1 won!";
    }else if((p2 == "rock" && p1 == "scissors") 
        || (p2 == "scissors" && p1 == "paper") 
        || (p2 == "paper" && p1 == "rock")){
            return "Player 2 won!";
    }else{
        return "Draw!";
    }
  }
  public static void Main(){
    Console.WriteLine(Rps("rock", "scissors"));
    Console.WriteLine(Rps("paper", "scissors"));
    Console.WriteLine(Rps("scissors", "scissors"));
  }
}
