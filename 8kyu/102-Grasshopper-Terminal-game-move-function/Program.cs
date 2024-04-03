// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Drawing;

public class Game
{
  public static int Move(int position, int roll) 
  {
  	// throw new NotImplementedException();
    return position+(roll*2);
  }
  public static void Main(){
    Console.WriteLine(Move(0,4));
  }
}
