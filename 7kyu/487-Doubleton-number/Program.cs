using System.Linq;
public static class Kata
{
    public static int Doubleton(int num)
    {
        // Insert code here ..
        do
        {
            num++;
        } while (num.ToString().Distinct().Count() != 2);
        return num;

        // Alternative 
        // while ((++num).ToString().Distinct().Count() != 2);
        // return num;
    }

    public static void Main()
    {
        Console.WriteLine(Doubleton(1234));
    }
}