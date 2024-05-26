public class Kata
{
  public static int[] SymmetricPoint(int[] p, int[] q)
  {
    int[] d = new int[]{p[0]-q[0], p[1]-q[1]};
    return new int[] { q[0]-d[0], q[1]-d[1] };

    // Alternative
    // return new [] { 2 * q[0] - p[0], 2 * q[1] - p[1] };
  }

  public static void Main(){
    foreach (var item in SymmetricPoint(new int[] {10, -10},  new int[] {-10, 10}))
    {
        Console.WriteLine(item);
    }
  }
}