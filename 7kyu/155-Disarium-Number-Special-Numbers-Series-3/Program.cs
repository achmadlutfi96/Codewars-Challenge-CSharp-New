class Kata
{
    public static string DisariumNumber(int number)
    {
        //Do Some Magic
        char[] n = number.ToString().ToCharArray();
        return Enumerable.Range(1, n.Length).Select((x,i)=>Math.Pow(char.GetNumericValue(n[i]), x)).Sum() == number ? "Disarium !!" : "Not !!";

        // Alternative
        // return number.ToString().Select((x,i) => Math.Pow(char.GetNumericValue(x), ++i)).Sum() == number ? "Disarium !!" : "Not !!";
    }

    public static void Main(){
        Console.WriteLine(DisariumNumber(89));
    }
}