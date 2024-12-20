using System;
using System.Linq;
public class Deutschstunde
{
  public static string DerDieDas(string wort)
  {
    //Du kannst es schaffen!
    int vowels = wort.ToLower().Where("aeiouäöü".Contains).Count();
    return vowels < 2  ? $"das {wort}" : (vowels == 2 || vowels == 3) ? $"die {wort}" : $"der {wort}";
  }

  public static void Main()
  {
    Console.WriteLine(DerDieDas("OOOpa"));
    Console.WriteLine(DerDieDas("Suppenhuhn"));
    Console.WriteLine(DerDieDas("Fisch"));
  }
}
