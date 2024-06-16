using System.Linq;
public class Kata
{
  public static bool IsAnagram(string test, string original)
  {
    // your code goes here
    // if(original.Length == test.Length){
    //     // char[] a = test.Order().ToArray();
    //     // char[] b = original.Order().ToArray();
    //     char[] a = test.ToLower().ToCharArray();
    //     Array.Sort(a);
    //     char[] b = original.ToLower().ToCharArray();
    //     Array.Sort(b);
    //     for (int i = 0; i < a.Length; i++)
    //     {
    //         if(a[i] != b[i]){
    //             return false;
    //         }   
    //     }
    //     return true;
    // }else{
    //     return false;
    // }

    // Alternative 1
    return string.Concat(test.ToLower().OrderBy(x=>x)) == string.Concat(original.ToLower().OrderBy(x=>x));

    // Alternative 2
    // return test.ToLower().OrderBy(x => x).SequenceEqual(original.ToLower().OrderBy(x => x));
  }

  public static void Main(){
    Console.WriteLine(IsAnagram("Buckethead", "DeathCubeK"));
  }
}