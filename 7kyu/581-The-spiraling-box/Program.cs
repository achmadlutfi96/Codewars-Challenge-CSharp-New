public class SpiralingBox
{
    public static int[,] CreateBox(int m, int n)
    {
        // Put your code here.
        int[,] array = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array[i,j] = 1+Math.Min(Math.Min(i, n - i - 1), Math.Min(j, m - j - 1));
            }
        }
        return array;
    }

    public static void Main()
    {
        int[,] res = CreateBox(4, 2);
        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}