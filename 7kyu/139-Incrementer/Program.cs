using System.Linq;
public static class Kata
{
    public static int[] Incrementer(int[] numbers)
    {
        return numbers.Select((v, i)=>(v+i+1)%10).ToArray(); // replace with your code ..
    }

    public static void Main(){
        Console.WriteLine(string.Join(", ", Incrementer(new int[]{1, 2, 3})));
    }
}