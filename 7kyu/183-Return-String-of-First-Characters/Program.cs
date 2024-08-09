using System.Linq;
public partial class Kata
{
  public static string MakeString(string s)
  {
    return string.Concat(s.Split(" ").Select(x=>x.First()));  

    // Alternative
    // return string.Concat(s.Split().Select(e => e[0]));   
  }

  public static void Main(){
    Console.WriteLine(MakeString("coding is awesome"));
  }
}