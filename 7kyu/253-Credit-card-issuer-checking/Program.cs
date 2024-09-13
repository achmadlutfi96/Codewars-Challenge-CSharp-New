using System.Text.RegularExpressions;

public static class Kata
{
    public static string getIssuer(long number)
    {
        //Code your solution here
        string n = number.ToString();
        if ((n.StartsWith("34") || n.StartsWith("37")) && n.Length == 15)
        {
            return "AMEX";
        }
        else if (n.StartsWith("6011") && n.Length == 16)
        {
            return "Discover";
        }
        else if ((n.StartsWith("51") || n.StartsWith("52") || n.StartsWith("53") || n.StartsWith("54") || n.StartsWith("55")) && n.Length == 16)
        {
            return "Mastercard";
        }
        else if (n.StartsWith("4") && (n.Length == 13 || n.Length == 16))
        {
            return "VISA";
        }
        else
        {
            return "Unknown";
        }

        // Alternative
        // var card = number.ToString();
        // if (Regex.IsMatch(card, "^3[47][0-9]{13}$")) return "AMEX";
        // if (Regex.IsMatch(card, "^6011[0-9]{12}$")) return "Discover";
        // if (Regex.IsMatch(card, "^5[1-5][0-9]{14}$")) return "Mastercard";
        // if (Regex.IsMatch(card, "^4([0-9]{12}|[0-9]{15})$")) return "VISA";
        // return "Unknown";
    }
    public static void Main()
    {
        Console.WriteLine(getIssuer(6011111111111117));
    }
}