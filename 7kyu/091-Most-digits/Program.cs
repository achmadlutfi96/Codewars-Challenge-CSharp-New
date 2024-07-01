public class Kata
{
  public static int FindLongest(int[] number)
  {
    // code here
    List<int> nlist = number.Select(x => x.ToString().Length).ToList();
    return number[nlist.IndexOf(nlist.Max())];

    // Alternative 1
    // return N.OrderByDescending(X => X.ToString().Length).First();
    // Alternative 2
    // return number.First(i => $"{i}".Length == $"{number.Max()}".Length);
  }

  public static void Main(){
    Console.WriteLine(FindLongest(new int[] {8, 900, 500}));
  }
}