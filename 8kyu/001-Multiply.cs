using System;

public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}

class Multiply{
    static void Main(string[] args){
        Console.WriteLine(CustomMath.multiply(2, 1));
    }
}

