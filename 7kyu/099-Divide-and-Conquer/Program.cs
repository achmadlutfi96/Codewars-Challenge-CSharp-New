using System;
using System.Linq;

public class Kata
{
  public static int DivCon(Object[] objArray)
  {
    return objArray.Where(i=>i.GetType()==typeof(int)).Sum(x=>(int)x) - objArray.Where(s=>s.GetType()==typeof(string)).Sum(x=>Convert.ToInt32(x));

    // Alternative
    // objArray.Sum(t=>(t is int) ?(int) t :-int.Parse((string)t))
  }

  public static void Main(){
    Console.WriteLine(DivCon(new object[] {9, 3, "7", "3"}));
  }
}