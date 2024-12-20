using System;
using System.Linq;

class EANValidator{
  public static bool Validate(string eanCode){
    //Your code here
    // Console.WriteLine((10-(eanCode.SkipLast(1).Select((v,i)=> i%2 == 0 ? char.GetNumericValue(v)*1 : char.GetNumericValue(v)*3).Sum()%10)).ToString().Last());
    // Console.WriteLine(eanCode.Last().ToString());
    return (10-(eanCode.SkipLast(1).Select((v,i)=> i%2 == 0 ? char.GetNumericValue(v)*1 : char.GetNumericValue(v)*3).Sum()%10)).ToString().Last() == eanCode.Last();

    // Alternative
    // return eanCode
        // .Select(c => int.Parse($"{c}"))
        // .Select((x, i) => i % 2 == 0 ? x : x * 3)
        // .Sum() % 10 == 0;
  }

  public static void Main()
  {
    // Console.WriteLine(Validate("4003301018398"));
    Console.WriteLine(Validate("9783815820865"));
    Console.WriteLine(Validate("9783815820864"));
    Console.WriteLine(Validate("9783827317100"));
  }
}