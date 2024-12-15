using System.Linq;
public class Grid {
  public static int NumberOfRectangles(int m, int n) {
    // Your code here!
    return Enumerable.Range(1,m).Select(x=>Enumerable.Range(1,n).Select(y=>x*y).Sum()).Sum();

    // Alternative
    // return (m*(m+1)*n*(n+1))/4;

    // Alternative 2
    // return m * n * ++m * ++n / 4;
  }

  public static void Main()
  {
    Console.WriteLine(NumberOfRectangles(3,2));
  }
}