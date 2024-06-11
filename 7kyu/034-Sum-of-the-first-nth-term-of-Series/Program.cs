using System;
using System.Collections.Generic;
using System.Linq;

public class NthSeries {
	
	public static string seriesSum (int n) {
		// Happy Coding ^_^
        if(n == 0) return "0.00";
        List<double> nums = new List<double>{1};
        for (int i = 0; i < n-1; i++)
        {
            nums.Add(nums[i]+3);
        }
        return Math.Round(nums.Sum<double>(a=>1/a),2).ToString("F2");

        // Alternative 1
        // return Enumerable.Range(0, n).Sum(x => 1.0 / (x * 3 + 1)).ToString("F");

        // Alternative 2
        // return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
	}

    public static void Main(){
        Console.WriteLine(seriesSum(1));
    }
}