public class Cogs {

  public static double cogRpm(int[] cogs) {
    // Your code here!
    return (cogs.Length % 2 == 0 ? -1d : 1d) * cogs[0] / cogs[cogs.Length-1];
  }
    public static void Main()
    {
        Console.WriteLine(cogRpm(new[] {100, 75}));
    }
}