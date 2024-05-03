public class Kata
{
    public static string Shark(
      int pontoonDistance, 
      int sharkDistance, 
      int youSpeed, 
      int sharkSpeed, 
      bool dolphin)
    {
        //your code here
        // var sharkPathTime = sharkDistance / (dolphin ? sharkSpeed*0.5 : sharkSpeed);
        // var youPathTime = pontoonDistance / youSpeed;
        // return youPathTime < sharkPathTime ? "Alive!" : "Shark Bait!";
        return (pontoonDistance/youSpeed < sharkDistance/(dolphin ? sharkSpeed*0.5 : sharkSpeed)) ? "Alive!" : "Shark Bait!";
    }

    public static void Main(){
        Console.WriteLine(Shark(12, 50, 4, 8, true));
        Console.WriteLine(Shark(12, 123, 2, 18, false));
    }
}