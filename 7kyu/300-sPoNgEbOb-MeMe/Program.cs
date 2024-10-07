using System.Linq;
public class Kata
{
  public static string SpongeMeme(string sentence)
  {
    return string.Concat(sentence.Select((x,i)=>i%2==0 ? char.ToUpper(x):char.ToLower(x)));
  }

  public static void Main(){
    Console.WriteLine(SpongeMeme("stop Making spongebob Memes!"));
  }
}