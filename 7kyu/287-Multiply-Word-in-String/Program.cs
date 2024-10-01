public class Kata
{
    public static string ModifyMultiply(string str,int loc,int num)
    {
        return string.Join("-", Enumerable.Repeat(str.Split(" ").ElementAt(loc), num));
    }

    public static void Main(){
        Console.WriteLine(ModifyMultiply("Talk is cheap Show me the code",2,4));
    }
}