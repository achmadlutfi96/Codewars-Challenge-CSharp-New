public class Kata
{
    public static string HowManyDalmatians(int n)
    {
        List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
        string respond =  (n <= 10) ? dogs[0] : (n <= 50) ? dogs[1] : (n == 101) ? dogs[3] : dogs[2];
        return respond;
    }
    public static void Main(){
        Console.WriteLine(HowManyDalmatians(26));
    }
}