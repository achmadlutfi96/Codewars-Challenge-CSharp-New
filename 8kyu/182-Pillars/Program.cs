using System.Net.Mail;

public static class Kata
{
 public static int Pillars(int numPill, int dist, int width)
  {
    int num = numPill-1;
    int flPillar = numPill <= 2 ? 0 : ((numPill-2)*width);;
    return (num*dist*100)+flPillar;

    // Alternative
    // return Math.Max(0, (100 * dist + width) * --numPill - width);
  }

  public static void Main(){
    Console.WriteLine(Pillars(2,20,25));
    Console.WriteLine(Pillars(1,10,10));
  }
}