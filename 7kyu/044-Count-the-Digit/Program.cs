using System;
using System.Linq;

public class CountDig 
{
    
    public static int NbDig(int n, int d) 
    {
        // your code
        return Enumerable.Range(0, n+1).Select(x=>(x*x).ToString()).Where(s=>s.Contains(d.ToString())).Select(x=>x.Where(a=>a.ToString().Equals(d.ToString())).Count()).Sum();

        // Alternative
        // return Enumerable.Range(0,n+1).Select(x=>(x*x).ToString().Count(y=>y-48==d)).Sum();
    }

    public static void Main(){
        Console.WriteLine(NbDig(5750, 0));
    }
}