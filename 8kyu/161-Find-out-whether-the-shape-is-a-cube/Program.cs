namespace CubeCheck
{
    using System;
    public class CubeChecker
    {
        public static bool IsCube(double volume, double side)
        {
            return volume == Math.Pow(side, 3) && (volume > 0 || side > 0);
        }
        public static void Main()
        {
            Console.WriteLine(IsCube(8, 2));
            Console.WriteLine(IsCube(1, 1));
            Console.WriteLine(IsCube(200, 4));
            Console.WriteLine(IsCube(-8, -2));
      }
    }
}