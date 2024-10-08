public class Kata
{
    public static int[] BubbleSortOnce(int[] input)
    {
        // Code the Bubblesort Algorithm here :D
        int[] res = input.ToArray();
        for (int i = 0; i < res.Length-1; i++)
        {
            if (res[i] > res[i+1]){
                int temp = res[i];
                res[i] = res[i+1];
                res[i+1] = temp;
            }
        }
        return res;
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", BubbleSortOnce(new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 })));
    }
}