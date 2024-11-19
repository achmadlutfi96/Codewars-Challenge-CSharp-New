using System.Linq;
public class Kata
{
  public static int TotalBill(string str)
  {
    //Write your function here...
    int count = str.Count(x=>x=='r');
    return (count-(count/5))*2; 

    // Alternative
    // int plates = str.Replace(" ", "").Length;
    // return (plates - plates / 5) * 2;
  }

  public static void Main()
  {
    Console.WriteLine(TotalBill("rrrrrrrrrrrrrrrrrr   rr r"));
  }
}