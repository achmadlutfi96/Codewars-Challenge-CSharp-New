// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class RentalCar {
    
    public static int RentalCarCost(int d) {
        // your code
        return d >= 7? d*40-50 : d >= 3 ? d*40-20 : d*40;
    }
    public static void Main(){
        Console.WriteLine(RentalCarCost(3));
    }
}
