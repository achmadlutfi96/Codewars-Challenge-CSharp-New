using System;

public static class Hands
{
  public static int[] GetPositions(int s)
  {
    // your code
		return new int[]{s%3, s/3%3, s/9%3};

        // Alternative
        // return new int[3] { s%3, s%9/3, s%27/9};
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ",GetPositions( 5 )));
  }  
}