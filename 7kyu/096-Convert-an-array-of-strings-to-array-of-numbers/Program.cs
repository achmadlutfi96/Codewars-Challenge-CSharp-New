public class stringArrayMethods
{
  public static double[] ToDoubleArray(string[] stringArray)
  {
    return stringArray.Select(d=>double.Parse(d)).ToArray();
  }

  public static void Main(){
    Console.WriteLine(ToDoubleArray(["1", "2", "3"]));
  }
}