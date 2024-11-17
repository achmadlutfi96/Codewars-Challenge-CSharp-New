using System;
using System.Linq;
public class Kata
{
  public static char[][] ChessBoard(int row, int columns)
  {
    return Enumerable.Range(0,row).Select((x,i)=>Enumerable.Range(0,columns).Select((y,j)=>i%2 == j%2 ? 'O' : 'X').ToArray()).ToArray();

    // Alternative 
    // return Enumerable.Range(0,h).Select(i=>Enumerable.Range(0,w).Select(j=>"OX"[(i+j)%2]).ToArray()).ToArray();
  }

  public static void Main()
  {
    foreach (char[] item in ChessBoard(6,4))
    {
        Console.WriteLine(string.Join(", ", item));
    }
    
  }
}