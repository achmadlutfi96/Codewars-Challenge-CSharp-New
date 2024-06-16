using System;

public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
    if(nums == null || nums.Length == 0){
      return new int[]{};
    }
    Array.Sort(nums);
    return nums;

    // Alternative
    // return nums?.OrderBy(i=>i).ToArray() ?? new int[0];
  }

  public static void Main(){
    foreach (var item in SortNumbers(new int[] { 20, 2, 10 }))
    {
        Console.WriteLine(item);
    }
  }
}