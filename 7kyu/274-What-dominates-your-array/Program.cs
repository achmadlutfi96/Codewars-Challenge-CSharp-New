public class Kata
{
  public static int WhoDominates(int[] array)
  {
    return array.DistinctBy(x=>x).Select(x=> new int[]{x, array.Where(y=>x==y).Count()}).Where(x=> x[1] > array.Length/2).DefaultIfEmpty(new int[]{-1,0}).First()[0];

    // Alternative
    // return array.GroupBy(i => i).FirstOrDefault(g => g.Count() > array.Length / 2)?.Key ?? -1;
  }

  public static void Main(){
    Console.WriteLine(WhoDominates(new int[] { 3,4,3,2,3,1,3,3 }));
    Console.WriteLine(WhoDominates(new int[] { 1,1,1,2,2,2 }));
  }
}