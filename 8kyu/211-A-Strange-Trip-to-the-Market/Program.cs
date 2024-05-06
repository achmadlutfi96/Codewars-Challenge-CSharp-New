public static class Kata 
{
  public static bool IsLockNessMonster(string sentence) 
  {
    // FIND THE LOCH NESS MONSTER. SAVE YOUR TREE FIDDY
    string str = sentence.ToLower();
    return str.Contains("tree fiddy") || str.Contains("3.50") || str.Contains("three fifty");

    // Alternative
    // return sentence.ToUpper().Contains("TREE FIDDY") || sentence.Contains("3.50");
  }

  public static void Main(){
    Console.WriteLine("");
  }
}