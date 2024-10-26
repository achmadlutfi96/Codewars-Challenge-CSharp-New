using System.Linq;
public class Kata
{
  public static int[] Solution(int number)
  {
    var nums = Enumerable.Range(1, number-1);
    int a = nums.Where(x=>x%3 == 0 && x%5 != 0).Count();
    int b = nums.Where(x=>x%5 == 0 && x%3 != 0).Count();
    int c = nums.Where(x=>x%3 == 0 && x%5 == 0).Count();
    return new int[]{a, b, c};

    // Alternative 
    // var a = (num - 1) / 3;
    // var b = (num - 1) / 5;
    // var c = (num - 1) / 15;
    
    // return new[] {a - c, b - c, c}; 
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", Solution(20)));
  }
}