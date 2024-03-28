// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
        // code goes here
        return l == w ? l*w : 2*(l+w);
    }
    public static void Main(){
        Console.WriteLine(AreaOrPerimeter(4, 4));
        Console.WriteLine(AreaOrPerimeter(6, 10));
    }
}
