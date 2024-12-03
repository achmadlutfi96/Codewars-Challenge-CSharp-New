using System;

public static class Kata
{
  public static string ArrMultiply(string[] arr)
  {
    return (Convert.ToInt32(arr[0]) * Convert.ToInt32(arr[1])).ToString();
  }
}