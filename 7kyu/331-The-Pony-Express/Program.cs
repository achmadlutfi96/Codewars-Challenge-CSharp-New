class Kata
{
    public static int Riders(int[] stations)
    {
        // Your code here
        int res = 1;
        int sum = 0;
        foreach (var item in stations)
        {
            if(sum + item > 100){
                res++;
                sum = item;
                continue;
            }
            sum += item;
        }
        return res;

        // Alternative
        // return s.Aggregate(new []{0, 1}, (t, i) => t[0] + i > 100 ? new []{i, t[1] + 1} : new []{t[0] + i, t[1]})[1];
    }

    public static void Main()
    {
        Console.WriteLine(Riders(new int[] { 6, 24, 6, 8, 28, 8, 23, 47, 17, 29, 37, 18, 40, 49 }));
        Console.WriteLine(Riders("90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90".Split(" ").Select(int.Parse).ToArray()));
    }
}