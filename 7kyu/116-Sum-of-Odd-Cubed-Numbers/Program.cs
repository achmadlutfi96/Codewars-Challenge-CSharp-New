public class Kata
{
  public static int CubeOdd(int[] arr)
  {
    
    // insert code here >.<
    return arr.Select(x=>(int)Math.Pow(x,3)).Where(x=>x%2!=0).Sum();

    // Alternative
    // return arr.Sum(i => i % 2 == 0 ? 0 : i * i * i);
  }

  static void Main(){
    Console.WriteLine(CubeOdd(new int[] {1, 2, 3, 4}));
    Console.WriteLine(CubeOdd(new int[] {-3, -2, 2, 3}));
  }
}