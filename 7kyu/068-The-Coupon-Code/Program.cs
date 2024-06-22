using System;

public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
  {
    if(DateTime.Parse(currentDate) > DateTime.Parse(expirationDate)){
        return false;
    }
    return enteredCode == correctCode;
  }

  public static void Main(){
    Console.WriteLine(CheckCoupon("123a","123","September 5, 2014","October 1, 2014"));
  }
}