public class Kata
{
    public static string CaffeineBuzz(int n)
    {
        string result;
        if (n % 3 == 0)
        {
            result = "Java";
            if (n % 4 == 0)
            {
                result = "Coffee";
            }

            if (n%2==0)
            {
                result += "Script";
            }
        }else{
            result = "mocha_missing!";
        }

        return result;

        // Alternative
        // return n % 3 == 0 ? (n % 4 == 0 ? "Coffee" : "Java") + (n % 2 == 0 ? "Script" : "") : "mocha_missing!";
    }

    public static void Main()
    {
        Console.WriteLine(CaffeineBuzz(1));
        Console.WriteLine(CaffeineBuzz(3));
        Console.WriteLine(CaffeineBuzz(6));
        Console.WriteLine(CaffeineBuzz(12));
    }
}