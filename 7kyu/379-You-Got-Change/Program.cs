public class Kata
{
    public static int[] GiveChange(int amount)
    {
        int temp = amount;
        int r6 = temp / 100;
        temp %= 100;
        int r5 = temp / 50;
        temp %= 50;
        int r4 = temp / 20;
        temp %= 20;
        int r3 = temp / 10;
        temp %= 10;
        int r2 = temp / 5;
        temp %= 5;
        int r1 = temp;
        return new int[] { r1, r2, r3, r4, r5, r6 };

        // Alternative
        //         return new[]
        //    {
        //         amount % 5,
        //         amount % 10 / 5,
        //         amount % 50 % 20 / 10,
        //         amount % 50 / 20,
        //         amount % 100 / 50,
        //         amount / 100
        //     };
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", GiveChange(365)));
    }
}