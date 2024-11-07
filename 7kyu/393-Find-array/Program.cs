using System.Linq;
public class Kata
{
  public static object[] FindArray(object[] arr1, int[] arr2)
  {
    if(arr1.Length == 0 || arr2.Length == 0){
        return new object[0];
    }
    return arr2.Where(x=>x<arr1.Length).Select(x=>arr1[x]).ToArray();

    // Alternative
    // return arr2.Where(v => v < arr1.Length).Select(v => arr1[v]).ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", FindArray(new object[] {0, 1, 5, 2, 1, 8, 9, 1, 5}, new int[] {1, 4, 7})));
  }
}