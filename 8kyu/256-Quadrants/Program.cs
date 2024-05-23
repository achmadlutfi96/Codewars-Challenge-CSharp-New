using System;

public static class Kata
{
  public static int Quadrant(int x, int y)
  {
    if(x > 0 && y > 0){
        return 1;
    } 
    if(x < 0 && y > 0){
        return 2;
    }
    if(x < 0 && y < 0){
        return 3;
    }
    if(x > 0 && y < 0){
        return 4;
    }
    return 0;

    // Alternative
    // return x > 0 ? y < 0 ? 4 : 1 : y > 0 ? 2 : 3;
  }
  public static void Main(){
    Console.WriteLine(Quadrant(3, 5));
  }
}