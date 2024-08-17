public class Kata
{
  public static string FireFight(string s)
  {
    return s.Replace("Fire", "~~");
  }

  public static void Main(){
    Console.WriteLine(FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
  }
}