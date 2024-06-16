public class Kata
{
  public static string[] SortByLength (string[] array)
  {
    return array.OrderBy(x => x.Length).ToArray();

    // Alternative
    // Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
    // return array;
  }

  public static void Main(){
    foreach (var item in SortByLength(new string[] { "Beg", "Life", "I", "To" }))
    {
        Console.WriteLine(item);
    }
  }
}