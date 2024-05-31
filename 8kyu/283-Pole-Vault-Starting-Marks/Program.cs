using System;

class PoleVault
{
    public static double StartingMark(double bodyHeight)
    {
        // Remember: Body height of 1.52 m --> starting mark: 9.45 m
        //           Body height of 1.83 m --> starting mark: 10.67 m
        // All other starting marks are based on these guidelines!

        return Math.Round((bodyHeight * 3.9354 + 3.4681) * 100) / 100;

        // Alternative
        //   var heightVariation = 1.83-1.52;
        //   var markVariation = 10.67-9.45;
        //   double initialHeight = 1.52;
        //   double initialMark = 9.45;
        //   var markPerHeight =  markVariation/heightVariation;

        //   return Math.Round(initialMark+(bodyHeight-initialHeight)*markPerHeight,2);
    }

    public static void Main()
    {
        Console.WriteLine(StartingMark(1.52));
        Console.WriteLine(StartingMark(1.83));
    }
}