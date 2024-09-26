public class Kata
{
    public static bool IsVeryEvenNumber(int number)
    {
        while(number.ToString().Length > 1){
            number = (int) number.ToString().Sum(x=>char.GetNumericValue(x));
        }
        return number%2==0;

        // Alternative
        // return (--n % 9 + 1) % 2 == 0;
    }

    public static void Main()
    {
        Console.WriteLine(IsVeryEvenNumber(88));
    }
}