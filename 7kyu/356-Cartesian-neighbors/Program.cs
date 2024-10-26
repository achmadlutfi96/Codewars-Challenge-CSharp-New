using System;
using System.Collections.Generic;

public class Kata
{
    public static IEnumerable<int[]> cartesianNeighbor(int x, int y)
    {
        List<int[]> k = new List<int[]>(){
            new int[]{ -1, -1},
            new int[]{ -1, 0},
            new int[]{ -1, 1},
            new int[]{ 0, -1},
            new int[]{ 0, 1},
            new int[]{ 1, -1},
            new int[]{ 1, 0},
            new int[]{ 1, 1}
        };
        return Enumerable.Range(0, 8).Select((r,i) => new int[]{ x+k[i][0], y+k[i][1]});

        // Alternative 1
        // for (int dx = -1; dx <= 1; dx++)
        //     for (int dy = -1; dy <= 1; dy++)
        //         if (dx != 0 || dy != 0)
        //             yield return new int[]{x + dx, y + dy};

        // Alternative 2
        // return Enumerable.Range(x - 1, 3).SelectMany(xn => Enumerable.Range(y - 1, 3).Where(yn => xn != x || yn != y).Select(yn => new[] { xn, yn }));
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", cartesianNeighbor(5, 7)));
    }
}
