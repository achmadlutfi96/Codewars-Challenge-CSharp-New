public class HQ9
{
  public static string? Interpret(string code)
  {
    //finish me
    if (code == "H"){
        return "Hello World!";
    }else if(code == "Q"){
        return code;
    }else if(code == "9"){
        string s = "";
        for (int i = 99; i >= 0 ; i--)
        {
            if(i == 0){
                s += "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
            }else{
                string now = i == 1 ? "1 bottle" : $"{i} bottles";
                string after = i == 2 ? "1 bottle" : i == 1 ?"no more bottles" : $"{i-1} bottles";
                s+=$"{now} of beer on the wall, {now} of beer.\nTake one down and pass it around, {after} of beer on the wall.\n";
            }
        }
        return s;
    }else{
        return null;
    }
  }

  public static void Main(){
    Console.WriteLine(Interpret("9"));
  }
}