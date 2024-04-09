using System.Linq;
public class Kata
{
  public static string TripleTrouble(string one, string two, string three)
  {
    //Solution
    string res = "";
    for (int i = 0; i < one.Length; i++)
    {
        res = res + one[i] + two[i] + three[i];
        // res += $"{one[i]}{two[i]}{three[i]}";
    }
    return res;

    // Alternative
    // return string.Concat(one.Select((x,i) => x.ToString() + two[i] + three[i]));
  }
  public static void Main(){
    Console.WriteLine(TripleTrouble("aa","bb","cc"));
  }
}