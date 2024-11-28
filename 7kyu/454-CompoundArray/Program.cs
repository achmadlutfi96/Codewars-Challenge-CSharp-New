using System;

public class CompoundArrayClass
{
    public static int[] CompoundArray(int[] a, int[] b)
    {
        // your code
        int[] res = new int[a.Length + b.Length];
        int ia = 0;
        int ib = 0;
        for (int i = 0; i < (a.Length + b.Length); i++)
        {
            if(a.Length <= ia){
                res[i] = b[ib];
                ib++; 
            }else if(b.Length <= ib){
                res[i] = a[ia];
                ia++; 
            }else{
                if(i%2 == 0){
                    res[i] = a[ia];
                    ia++;
                }else{
                    res[i] = b[ib];
                    ib++;
                }
            }
        }
        return res;

        // Alternative
        // return Enumerable.Range(0, Math.Max(a.Length, b.Length))
        // .SelectMany((_, i) => a.Skip(i).Take(1).Concat(b.Skip(i).Take(1)))
        // .ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", CompoundArray(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 9, 8, 7, 6 })));
    }
}