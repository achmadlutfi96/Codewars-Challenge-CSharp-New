public class EmailObfuscator 
{
    
    public static string Obfuscate(string email) 
    {

        return email.Replace("@", " [at] ").Replace(".", " [dot] ");
    }

    public static void Main()
    {
        Console.WriteLine(Obfuscate("test@123.com"));
    }
}