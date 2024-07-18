public class Kata
{
  public static int? FoldTo(double distance)
  {
    if(distance < 0) return null;
    int fold = 0;
    double thickness = 0.0001;
    while (thickness < distance)
    {
        thickness *= 2;
        fold++;     
    }
    return fold;

    // Alternative
    // return distance < 0 ? null : (int?) (distance < 0.0001 ? 0 : Math.Ceiling(Math.Log(distance * 10000, 2)));
  }

  public static void Main(){
    Console.WriteLine(FoldTo(384000000));
  }
}