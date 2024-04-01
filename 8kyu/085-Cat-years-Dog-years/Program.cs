// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Dinglemouse
{

    public static int[] humanYearsCatYearsDogYears(int humanYears)
    {
        // Your code here!
        int catYears = 0;
        int dogYears = 0;
        if (humanYears == 1)
        {
            catYears = 15;
            dogYears = 15;
        }
        else if(humanYears == 2){
            catYears = 15+9;
            dogYears = 15+9;
        }
        else{
            catYears = ((humanYears-2)*4)+15+9;
            dogYears = ((humanYears-2)*5)+15+9;
        }
        return new int[] { humanYears, catYears, dogYears };

        // Alternative
    //     int catYear = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears-2): 0);
    //      int dogYear = 15+ (humanYears >= 2 ? 9 + 5 * (humanYears-2): 0);
    // return new int[] { humanYears, catYears, dogYears };
    }
    public static void Main()
    {
        foreach (var item in humanYearsCatYearsDogYears(2))
        {
            Console.WriteLine(item);
        }

    }
}