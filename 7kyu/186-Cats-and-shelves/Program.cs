public class Kata 
{
    public static int Cats(int start, int finish) 
    {
      //Mew
        int diff = finish - start;
        return diff/3 + diff % 3;
    }

    public static void Main(){
        Console.WriteLine(Cats(1,5));
    }
}