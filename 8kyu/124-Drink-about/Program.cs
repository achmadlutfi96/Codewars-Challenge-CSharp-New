public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    return String.Concat("drink ", old < 14 ? "toddy" : old<18 ? "coke" : old<21 ? "beer" : "whisky");
    // Alternative
    // return "drink "+(old < 14 ? "toddy" : old<18 ? "coke" : old<21 ? "beer" : "whisky");
  }
  public static void Main(string[] args){
    Console.WriteLine(PeopleWithAgeDrink(22));
  }
}