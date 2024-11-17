public class Birthday
{
  public static string Cake(int x, string y)
  {
    // Console.WriteLine(y.Select((v,i)=> i%2 == 0 ? v : v-96).Sum() * 0.7);
    // Console.WriteLine("abc".Select((v,i)=>i%2 == 0 ? v : v-96).Sum());
    return y.Select((v,i)=> i%2 == 0 ? v : v-96).Sum() >= x * 0.7 ? "Fire!" : "That was close!" ;
  }

  public static void Main()
  {
    Console.WriteLine(Cake(900, "abcdef"));
    Console.WriteLine(Cake(56, "ifkhchlhfd"));
    Console.WriteLine(Cake(256, "aaaaaddddr"));
    Console.WriteLine(Cake(501, "ipmnwnpen"));
    Console.WriteLine(Cake(339, "aoq"));
  }
}