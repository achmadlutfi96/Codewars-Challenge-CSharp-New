public class Opstrings
{   
    public static string VertMirror(string strng)
    {
        // your 
        return string.Join('\n',strng.Split("\n").Select(x=>string.Concat(x.Reverse())));
    }
    public static string HorMirror(string strng)
    {
       return string.Join("\n",strng.Split("\n").Reverse().ToArray());
    }
    public static string Oper(Func<string, string> fct, string s)
    {
        // your code and complete ... before operator
        return fct(s);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine(Opstrings.Oper(Opstrings.HorMirror, "lVHt\nJVhv\nCSbg\nyeCt"));
        Console.WriteLine(Opstrings.Oper(Opstrings.VertMirror,"hSgdHQ\nHnDMao\nClNNxX\niRvxxH\nbqTVvA\nwvSyRu"));
    }
}