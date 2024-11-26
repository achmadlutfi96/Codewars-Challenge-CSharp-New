using System.Linq;
public class Kata
{
    public static string Part(string[] x)
    {
        var terms = new string[] { "Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad"};
        int sum = x.Count(y=>terms.Contains(y));
        if(sum > 0){
            return $"Mine's a Pint{string.Concat(Enumerable.Repeat('!',sum))}";
        }
        return "Lynn, I've pierced my foot on a spike!!";
    }

    public static void Main()
    {
        Console.WriteLine(Part(new String[] { "Grouse", "Partridge", "Pheasant" }));
        Console.WriteLine(Part(new String[] { "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster" }));
        Console.WriteLine(Part(new string[] { "Pheasant", "Goose", "Starling", "Robin" }));
    }
}