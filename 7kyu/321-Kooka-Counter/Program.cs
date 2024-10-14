public class Dinglemouse
{
    public static int KookaCounter(string laughing)
    {
        // Your code here!
        int male = laughing.Split("ha").Where(x=>x!="").Count();
        int female = laughing.Split("Ha").Where(x=>x!="").Count();
        return male+female;

        // Alternative
        // return Regex.Matches(laughing, "(Ha)+|(ha)+").Count;
    }

    public static void Main()
    {
        Console.WriteLine(KookaCounter(string.Empty));
        Console.WriteLine(KookaCounter("hahahahaha"));
        Console.WriteLine(KookaCounter("hahahahahaHaHaHa"));
        Console.WriteLine(KookaCounter("HaHaHahahaHaHa"));
    }
}