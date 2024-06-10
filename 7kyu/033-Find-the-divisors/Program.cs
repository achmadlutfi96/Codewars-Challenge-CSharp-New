public class Kata
{
    public static int[]? Divisors(int n)
    {
        int[] nums = Enumerable.Range(2, n-2).Where(x=>n%x == 0).ToArray();
        if(nums.Length == 0){
            return null;
        }
        return nums;

        // Alternative
        // var div = Enumerable.Range(2, n-2).Where(x=>n%x == 0).ToArray();
        // return div.Any() ? div : null;
    }

    public static void Main()
    {
        foreach (var item in Divisors(253))
        {
            Console.WriteLine(item);
        }

        foreach (var item in Divisors(15))
        {
            Console.WriteLine(item);
        }
        foreach (var item in Divisors(13))
        {
            Console.WriteLine(item);
        }
    }
}