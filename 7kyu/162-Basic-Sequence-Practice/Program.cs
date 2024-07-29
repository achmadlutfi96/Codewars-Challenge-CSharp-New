using System;
using System.Linq;
public class SequenceSum
{
	public static int[] SumOfN(int n)
	{
    //TODO: Write your solution here
        int[] sum = new int[Math.Abs(n)+1];
		// throw new System.NotImplementedException();
        for (int i = 0; i <= Math.Abs(n); i++){
            sum[i] = Enumerable.Range(0,i+1).Sum();
            if(n<0){
                sum[i] *= -1;
            }            
        }
        return sum; 

        // Alternative
        //  return Enumerable.Range(0, Math.Abs(n) + 1).Select(i => Math.Sign(n) * i * (i + 1) / 2).ToArray();
	}

    public static void Main(){
        Console.WriteLine(string.Join(",", SumOfN(-4)));
    }
}