public class Kata
{
  /// <summary>
  /// Returns the Stanton Measure of the array</summary>
  /// <param name="arr">Int32[] to be evaluated.</param>
  public static int StantonMeasure(int[] arr)
  {
    return arr.Where(y=> y == arr.Where(x=>x==1).Count()).Count();

    // Alternative
    // int n = arr.Count(x => x == 1);
    // return arr.Count(x => x == n);
  }

  public static void Main(){
    Console.WriteLine(StantonMeasure(new int[] {1, 4, 3, 2, 1, 2, 3, 2}));
  }
}