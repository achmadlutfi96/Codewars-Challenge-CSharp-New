public class Kata
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
       return (x1*y2) - (x2*y1) == 0;

       // Alternative
    //    return x1 * y2 == y1 * x2;
    }
    
    public static void Main(){
        Console.WriteLine(Collinearity(1, -2, -2, 4));
    }
}