using System.Linq;
public class Kata
{
  public static int GetNewNotes(int salary, int[] bills)
  {
    if(salary < bills.Sum()) return 0;
    return (salary-bills.Sum())/5;
  }

  public static void Main()
  {
    Console.WriteLine(GetNewNotes(2000, new int [] { 500, 160, 400 }));
  }
}