public class Kata
{
  public static double[] Averages(int[] numbers)
  {
    if(numbers == null || numbers.Length < 2) return new double[]{};
    double[] result = new double[numbers.Length-1];
    for (int i = 0; i < numbers.Length-1; i++){
        result[i] = (double)(numbers[i]+numbers[i+1])/2;
    }
    return result;

    // Alternative 1
    // return numbers?.Zip(numbers.Skip(1), (x, y) => (x + y) / 2.0).ToArray() ?? new double[0];

    // Alternative 2
    // return numbers?.Skip(1).Select((x, i) => (x + numbers[i]) / 2.0).ToArray() ?? new double[0];
  }

  public static void Main(){
    foreach (var item in Averages(new int[] { 1, 3, 5, 1, -10 }))
    {
        Console.WriteLine(item);
    }
    foreach (var item in Averages(new int[] {}))
    {
        Console.WriteLine(item);
    }
  }
}