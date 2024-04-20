using System;

public class Kata
{
  public static int HowManyLightsabersDoYouOwn(string name)
  {
    //Code goes here
    return name.Equals("Zach") ? 18 : 0;
  }

  public static void Main(){
    Console.WriteLine(HowManyLightsabersDoYouOwn("Zach"));
  }
}