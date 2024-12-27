using System;
using System.Linq;
class Kata
{
    public static int[] OrArrays(int[] arr1, int[] arr2, int d = 0)
    {
        int[] a = arr1.Length >= arr2.Length ? arr1 : arr2;
        int[] b = arr1.Length >= arr2.Length ? arr2 : arr1;

        int[] res = new int[Math.Max(arr1.Length, arr2.Length)];
        for (int i = 0; i < res.Length; i++)
        {
            string temp1 = Convert.ToString(a[i],2);
            string temp2 = "";
            if(i >= b.Length){
                temp2 = Convert.ToString(d,2);
            }else{
                temp2 = Convert.ToString(b[i],2);
            }
            temp1 = temp1.PadLeft(Math.Max(temp1.Length, temp2.Length), '0');
            temp2 = temp2.PadLeft(Math.Max(temp1.Length, temp2.Length), '0');
            res[i] = Convert.ToInt32(string.Concat(temp1.Select((v,i)=>v == '1' || temp2[i] == '1' ? '1' : '0')), 2); 
        }
        return res;

        // 
    }

    public static void Main()
    {
        // Console.WriteLine(string.Join(", ",OrArrays([1,2,3],[1,2,3])));
        Console.WriteLine(string.Join(", ",OrArrays([1,2,3],[4,5,6])));
        // Console.WriteLine(string.Join(", ",OrArrays([1,2,3],[1,2])));
        // Console.WriteLine(string.Join(", ",OrArrays([1,2],[1,2,3])));
        // Console.WriteLine(string.Join(", ",OrArrays([1,2,3],[1,2,3],3)));
    }

    // Alternative
    // return arr1.Zip(arr2, (x, y) => x | y)
            //   .Concat(arr1.Skip(arr2.Length).Select(x => x | d))
            //   .Concat(arr2.Skip(arr1.Length).Select(x => x | d))
            //   .ToArray();
}