public class Kata
{
  public static string WhoseMove(string lastPlayer, bool win)
  {
    //coding and coding..
    if(lastPlayer == "black"){
        if(win){
            return "black";
        }else{
            return "white";
        }
    }else{
        if(win){
            return "white";
        }else{
            return "black";
        }
    }
    // Alternative
    // return win ? lastPlayer : lastPlayer == "black" ? "white" : "black";
  }

  public static void Main(){
    Console.WriteLine(WhoseMove("black", false));
  }
}