using System.Linq;
public class Kata
{
  public static string Vowel2Index(string str)
  {
    //code me
    return string.Concat(str.Select((v,i)=>"aiueo".Contains(v)? (i+1).ToString()  : v.ToString()));
  }

  public static void Main(){
    Console.WriteLine(Vowel2Index("this is my string"));
  }
}