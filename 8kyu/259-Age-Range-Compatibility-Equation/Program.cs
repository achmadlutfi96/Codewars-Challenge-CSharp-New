using System;
public class Kata
{
  public static string DatingRange(int age)
  {
    // return min-max
    int min, max;
    if(age <= 14){
        min = (int) Math.Floor(age - (0.10 * age));
        max = (int) Math.Floor(age + (0.10 * age));
        return $"{min}-{max}";
    }else{
        min = (age/2) + 7;
        max = (age-7) * 2;
        return $"{min}-{max}";
    }
  }

  public static void Main(){
    Console.WriteLine(DatingRange(17));
  }
}