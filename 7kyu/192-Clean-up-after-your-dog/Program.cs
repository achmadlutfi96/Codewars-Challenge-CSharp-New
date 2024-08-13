public class Kata
{
  public static string Crap(char[,] x, int bags, int cap)
  {
    int totalCap = bags*cap;
    int crap = 0;

    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            if(x[i,j] == 'D'){
                return "Dog!!";
            }
            if(x[i,j] == '@'){
                crap++;
            }
        }
    }

    return crap > totalCap ? "Cr@p" : "Clean";

    // Alternative
    // return x.Cast<char>().Contains('D') ? "Dog!!" : x.Cast<char>().Count(c => c == '@') > bags * cap ? "Cr@p" : "Clean";
  }

  public static void Main(){
    Console.WriteLine(Crap(new char[,] {{'_','_','_','_'}, {'_','_','_','@'}, {'_','_','@', '_'}}, 2, 2));

    Console.WriteLine(Crap(new char[,] {{'_','_','_','_'}, {'_','_','_','@'}, {'_','_','@', '_'}}, 1, 1));
    
    Console.WriteLine(Crap(new char[,] {{'_','_'}, {'_','@'}, {'D','_'}}, 2, 2));
  }
}