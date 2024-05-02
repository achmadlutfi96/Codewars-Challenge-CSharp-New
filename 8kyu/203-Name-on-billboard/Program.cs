using System.Linq;
public class Kata {
  public static double Billboard(string name, double price = 30) {
    double result = 0;
    for (int i = 0; i < name.Length; i++)
    {
         result+=price; 
    }
    return result;

    // Alternative
    // return name.Sum(_ => price);
  }

  public static void Main(){
    Console.WriteLine(Billboard("Jeong-Ho Aristotelis"));
  }
}