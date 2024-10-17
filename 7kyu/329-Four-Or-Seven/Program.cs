public class Kata {
  public static int FourSeven(int num) {
    // Start!
    while(num!=4 && num!=7){return 0;}
    return 11-num;

    // Alternative 1
    // return new Dictionary<int, int> {{4, 7}, {7, 4}}.GetValueOrDefault(num);

    // Alternative 2
    // return Convert.ToInt32(num == 4 || num == 7) * (11 - num);
  }

  public static void Main(){
    Console.WriteLine(FourSeven(7));
    Console.WriteLine(FourSeven(4));
    Console.WriteLine(FourSeven(100));
  }
}