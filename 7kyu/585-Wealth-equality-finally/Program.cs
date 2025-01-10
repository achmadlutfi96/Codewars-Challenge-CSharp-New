using System.Linq;
public class Kata {
  public static void RedistributeWealth(double[] wealth) {
    // Start! Remember to mutate the input
    double avg = wealth.Average();
    for (int i = 0; i < wealth.Length; i++)
    {
        wealth[i] = avg;
    }

    // Alternative
    // var avg = wealth.Average();
    // Array.Fill(wealth, avg);
  }
}