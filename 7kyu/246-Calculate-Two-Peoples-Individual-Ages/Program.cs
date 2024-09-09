public class Kata
{
  public static double[] GetAges(int sum, int difference)
  {
    if(sum < 0 || difference < 0){
       return null; 
    }
    double x = (double)sum / 2;
    double y = (double)difference / 2;

    double ageA = x + y;
    double ageB = x - y;

    if(ageA < 0 || ageB < 0){
        return null;
    }
    return new double[] { ageA, ageB };

    // Alternative
    // return sum < 0 || difference < 0 || sum < difference
        // ? null
        // : new[] {(sum + difference) / 2d, (sum - difference) / 2d};
  }

  public static void Main(){
    Console.WriteLine(string.Join(",",GetAges(24, 4)));
    Console.WriteLine(string.Join(",",GetAges(63, 14)));
  }
}