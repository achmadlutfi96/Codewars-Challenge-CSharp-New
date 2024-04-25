using System.Linq;
public class Kata
{
  public static string Remove(string s)
  {
    //coding and coding...
    int del = 0;
    foreach (var item in s.Reverse())
    {
        if(item.Equals('!')){
            del++;
        }else{
            break;
        }
    }
    return s.Remove(s.Length - del, del);

    // Alternative
    // return s.TrimEnd('!'); 
  }

  public static void Main(){
    Console.WriteLine(Remove("Hi!!!"));
  }
}
