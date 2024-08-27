public partial class Kata
{
  public static string MakeBackronym(string s)
  {
    return string.Join(" ",s.Select(x=>dict[char.ToUpper(x)])); // "awesome"
  }

  public static void Main(){
    Console.WriteLine(MakeBackronym("interesting"));
  }
}