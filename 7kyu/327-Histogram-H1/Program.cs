using System.Linq;
public class Dinglemouse
{
    public static string Histogram(int[] results)
    {
        return string.Join("\n",results.Select((v,i)=>v==0 ? $"{i+1}|" :$"{i+1}|{string.Concat(Enumerable.Repeat('#',v))} {v}").Reverse())+"\n";
    }

    public static void Main()
    {
        Console.WriteLine(Histogram(new int[]{ 7,3,10,1,0,5 }));
    }
}