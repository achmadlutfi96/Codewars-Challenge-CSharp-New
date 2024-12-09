using System.Linq;
using System;
class Kata
{
    public static string WorkNeeded(int projectMinutes, int[][] freelancers)
    {
        //Do Some Magic
        int totalMinutes = freelancers.Select(x => (x[0] * 60) + x[1]).Sum();
        int work = projectMinutes - totalMinutes;
        return work <= 0 ? "Easy Money!" : $"I need to work {work / 60} hour(s) and {work % 60} minute(s)";

        // Alternative
        // var minutes = projectMinutes - freelancers.Sum(i => i[0] * 60 + i[1]);
        // return minutes > 0 ? $"I need to work {minutes / 60} hour(s) and {minutes % 60} minute(s)" : "Easy Money!";
    }

    public static void Main()
    {
        var arr = new int[][] { new[] { 1, 0 } };
        Console.WriteLine(WorkNeeded(60, arr));
        var arr2 = new int[][] { new[] { 1, 55 }, new[] { 0, 25 } };
        Console.WriteLine(WorkNeeded(141, arr2));
    }
}