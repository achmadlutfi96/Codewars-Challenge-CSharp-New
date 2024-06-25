using System.Linq;
public class Kata
{
    public static string IsSortedAndHow(int[] array)
    {
        // int[] arr1 = new int[array.Length];
        // int[] arr2 = new int[array.Length];
        // Array.Copy(array, arr1, array.Length);
        // Array.Copy(array, arr2, array.Length);
        // // Array.Sort(arr1);
        // // Array.Sort(arr2);
        // // Array.Reverse(arr2);
        // arr1 = arr1.OrderBy(x=>x).ToArray();
        // arr2 = arr2.OrderByDescending(x=>x).ToArray();
        // foreach (var i in arr1)
        // {
        //     Console.Write(i+" ");

        // }
        // Console.WriteLine();
        // foreach (var i in arr2)
        // {
        //     Console.Write(i+" ");

        // }
        // Console.WriteLine();
        // if(Array.TrueForAll(arr1.Select((v, i)=>v==array[i]).ToArray(), (x)=>x)){
        //     return "yes, ascending";
        // }else if(Array.TrueForAll(arr2.Select((v, i)=>v==array[i]).ToArray(), (x)=>x)){
        //     return "yes, descending";
        // }else{
        //     return "no";
        // }

        return array.OrderBy(x => x).Select((v, i) => v == array[i]).All(x => x == true) ? "yes, ascending" : array.OrderByDescending(x => x).Select((v, i) => v == array[i]).All(x => x == true) ? "yes, descending" : "no";

        // Alternative
        // if(array.OrderBy(a=>a).SequenceEqual(array)) return "yes, ascending";
        // if(array.OrderByDescending(a=>a).SequenceEqual(array)) return "yes, descending";
        // return "no";

    }

    public static void Main()
    {
        Console.WriteLine(IsSortedAndHow(new[] { 15, 7, 3, -8 }));
    }
}