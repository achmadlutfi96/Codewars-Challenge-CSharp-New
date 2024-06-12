using System;
using System.Linq;
public class Kata
{
  public static int DontGiveMeFive(int start, int end)
  {
    
    return Enumerable.Range(start, end-start+1).Where(x=>!x.ToString().Any<char>(n=>n.Equals('5'))).Count();

    // Alternative
    // return Enumerable.Range(start, end-start+1).Count(x => !x.ToString().Contains("5"));
    
  }

  public static void Main(){
    Console.WriteLine(DontGiveMeFive(1,9));
    Console.WriteLine(DontGiveMeFive(4,17));
  }
}