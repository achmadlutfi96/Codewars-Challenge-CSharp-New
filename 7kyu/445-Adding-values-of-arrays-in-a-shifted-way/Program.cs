public class Kata
{
  public static int[] AddingShifted(int[][] arrayOfArrays, int shift)
  {
    int [] arrayOfSums = new int[arrayOfArrays[0].Length + shift * (arrayOfArrays.Length -1) ];
    int offset=0;
    for (int i = 0 ; i < arrayOfArrays.Length ; i++) {
      for (int j = 0 ; j < arrayOfArrays[i].Length ; j++ ) {
        arrayOfSums[j+offset] += arrayOfArrays[i][j];
      }
      offset += shift;
    }
    return arrayOfSums;

    // Alternative
    // return arrayOfArrays.Select((x, i) => Enumerable.Repeat(0, i * shift).Concat(x))
        // .Aggregate((a, b) => a.Concat(Enumerable.Repeat(0, shift)).Zip(b, (m, n) => m + n)).ToArray();
  }

  public static void Main()
  {
    var arrayOfArrays = new int[][] { new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 7, 7, 7, 7, 7, 7 } };
    Console.WriteLine(string.Join(", ",AddingShifted(arrayOfArrays, 3)));
  }
}