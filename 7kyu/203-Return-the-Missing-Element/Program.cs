using System;

public static class Kata
{
  public static int GetMissingElement(int[] superImportantArray)
  {
    //TODO
    return Enumerable.Range(0, 10).Except(superImportantArray).First();

    // Alternative 1
    // return (int)Enumerable.Range(0,9).Except(superImportantArray).FirstOrDefault();

    // Alternative 2
    // return 45 - superImportantArray.Sum();
  }

  public static void Main(){
    Console.WriteLine(GetMissingElement(new int[9] {0,5,1,3,2,9,7,6,4}));
  }
}