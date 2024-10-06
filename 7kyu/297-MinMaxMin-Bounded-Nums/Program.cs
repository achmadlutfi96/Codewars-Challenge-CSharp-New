using System.Linq;
public class Kata
{
  public static int[] MinMinMax(int[] array)
  {
    // solution goes here!
    int a = array.Min();
    int b = a+1;
    while (array.Contains(b)){
        b +=1;
    }
    int c = array.Max();
    return new int[] { a, b , c};

    // Alternative
    // return new[] {a.Min(), Enumerable.Range(a.Min(), a.Max()).Except(a).First(), a.Max()};
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", MinMinMax(new int[] {1, 3, -3, -2, 8, -1})));
  }
}