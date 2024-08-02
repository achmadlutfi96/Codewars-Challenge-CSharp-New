public class Kata
{
  public static int[] Remove(int[] integerList, int[] valuesList)
  {
    // your code here
    return integerList.Where(x=>!valuesList.Contains(x)).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", Remove([1, 1, 2, 3, 1, 2, 3, 4], [1,3])));
  }
}