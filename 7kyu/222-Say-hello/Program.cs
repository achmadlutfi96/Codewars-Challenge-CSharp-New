public class Greetings
{
    public static string greet(string name)
    {
        //Here add your greet code
        if (string.IsNullOrEmpty(name)){
            return null;
        }
        return $"hello {name}!";

        // Alternative
        // return string.IsNullOrEmpty(name) ? null : $"hello {name}!";
    }

    public static void Main(){
        Console.WriteLine(greet(null));
    }
}