public class Kata
{
  public static int Mango(int quantity, int price)
  {
    return (quantity-(quantity/3))*price;
  }

  public static void Main(){
    Console.WriteLine(Mango(9, 5));
  }
}