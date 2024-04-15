public class Kata
{
  public static int SeatsInTheater(int nCols, int nRows, int col, int row)
  {
    //coding and coding...
    return (nCols-(col-1)) * (nRows-row);
  }
  public static void Main(){
    Console.WriteLine(SeatsInTheater(16, 11, 5, 3));
    Console.WriteLine(SeatsInTheater(1, 1, 1, 1));
    Console.WriteLine(SeatsInTheater(13, 6, 8, 3));
  }
}