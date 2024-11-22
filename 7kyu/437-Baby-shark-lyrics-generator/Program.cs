using System.Linq;
public static class Kata {
  public static string BabySharkLyrics()=>string.Concat(new[]{"Baby","Mommy","Daddy","Grandma","Grandpa"}.Select(s=>s+" shark").Append("Let's go hunt").Select(x=>string.Join(", doo doo doo doo doo doo\n",Enumerable.Repeat(x,4))+"!\n"))+"Run away,…\n";
}