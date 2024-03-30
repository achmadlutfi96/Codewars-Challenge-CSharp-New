// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
  public static object FirstNonConsecutive(int[] arr)
  {
    for(int i = 0; i < arr.Length-1; i++){
        if(arr[i]+1 != arr[i+1]){
            return arr[i+1];
        }
    }
    return null;
    // Alternative
    // return arr.Cast<int?>().Skip(1).FirstOrDefault(i => i != ++arr[0]);
  }
  public static void Main(){
    Console.WriteLine(FirstNonConsecutive(new int[] {1, 2, 3, 4, 6, 7, 8}));
  }
}
