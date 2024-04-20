public class Kata
{
    public static string GetDrinkByProfession(string p)
    {
        return p.ToLower() switch
        {
            "jabroni"           => "Patron Tequila",
            "school counselor"  => "Anything with Alcohol",
            "programmer"        => "Hipster Craft Beer",
            "bike gang member"  => "Moonshine",
            "politician"        => "Your tax dollars",
            "rapper"            => "Cristal",
            _                   => "Beer"
        };
    }

    public static void Main()
    {
        Console.WriteLine(GetDrinkByProfession("bike ganG member"));
    }
}