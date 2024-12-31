using System.Linq;
public class Kata
{
  public static string[] Equalize(int[] array)
  {
    return array.Select(x=>x>=array[0] ? $"+{x-array[0]}" : $"-{array[0]-x}").ToArray();

    // Alternative
    // return array.Select(i => $"{i - array[0]:+0;-#}").ToArray();
  }
}