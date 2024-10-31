public class Kata
{
    public static string Task(string w, int n, int c)
    {
        //your code
        string name = w switch {
            "Monday" => "James",
            "Tuesday" => "John",
            "Wednesday" => "Michael",
            "Thursday" => "Robert",
            "Friday" => "William",
            _ => ""
        };        
        return $"It is {w} today, {name}, you have to work, you must spray {n} trees and you need {c*n} dollars to buy liquid";

        // Alternative
        // var name = new[] {"James", "John", "Robert", "Michael", "William"}[(int) Enum.Parse(typeof(DayOfWeek), w) - 1];
    // return $"It is {w} today, {name}, you have to work, you must spray {n} trees and you need {n * c} dollars to buy liquid";
    }

    public static void Main()
    {
        Console.WriteLine(Task("Tuesday", 6, 1));
    }
}