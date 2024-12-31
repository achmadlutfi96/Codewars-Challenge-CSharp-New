using System.Linq;
public class BitShift
{
    public static int[][] BitMarch(int n)
    {
        if (n < 1)
        {
            return new int[0][];
        }
        int row = 9 - n;
        int[][] res = new int[row][];
        for (int i = 0; i < row; i++)
        {
            int[] temp = new int[8];
            for (int j = 0; j < 8; j++)
            {
                if (j < 8 - n - i)
                {
                    temp[j] = 0;
                }
                else if (j >= 8 - n - i && j < 8-i){
                    temp[j] = 1;
                }else
                {
                    temp[j] = 0;
                }
            }
            res[i] = temp;
        }

        return res;

        // return Enumerable.Range(0,9-n)
        //   .Select(x=>Enumerable.Repeat(0, 8-n-x)
        //           .Concat(Enumerable.Repeat(1,n))
        //           .Concat(Enumerable.Repeat(0,x))
        //           .ToArray())
        //   .ToArray();
    }

    public static void Main()
    {
        foreach (var items in BitMarch(2))
        {
            foreach (var item in items)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

    }
}