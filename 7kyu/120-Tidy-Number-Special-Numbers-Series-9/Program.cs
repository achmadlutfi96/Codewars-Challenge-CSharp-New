using System.Linq;
class Kata
{
    public static bool TidyNumber(int n)
    {
        //Do Some Magic
        return n.ToString() == string.Concat(n.ToString().OrderBy(x=>x));

        // Alternative
        // return $"{n}" == string.Concat($"{n}".OrderBy(c => c));
    }

    public static void Main(){
        Console.WriteLine(TidyNumber(2789));
    }
}