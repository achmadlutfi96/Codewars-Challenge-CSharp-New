public partial class Kata
{
    public static string ChineseZodiac(int year)
    {
        string[] animals = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

        string[] elements = { "Wood", "Fire", "Earth", "Metal", "Water" };

        int baseYear = 1924; // The year of the Wood Rat 

        int yearDifference = year - baseYear;

        // Calculate the animal index 
        int animalIndex = (yearDifference % 12 + 12) % 12; // Modulo operation to handle negative values 
        // Calculate the element index 
        int elementIndex = ((yearDifference / 2) % 5 + 5) % 5; // Modulo operation to handle negative values 
        // Get the corresponding animal and element 
        string animal = animals[animalIndex];
        string element = elements[elementIndex];

        return $"{element} {animal}";

        // Alternative
        // int yearOffset = year - 1924;
        // return elements[(yearOffset / 2) % 5] + " " + animals[yearOffset % 12];
    }

    public static void Main()
    {
        Console.WriteLine(ChineseZodiac(1965));
    }
}