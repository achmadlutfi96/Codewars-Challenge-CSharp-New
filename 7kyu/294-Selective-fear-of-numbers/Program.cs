using System;

public static class Kata
{
    public static bool AmIAfraid(string day, int num)
    {
        //Help me...
        if (day == "Monday" && num == 12)
        {
            return true;
        }
        else if (day == "Tuesday" && num > 95)
        {
            return true;
        }
        else if (day == "Wednesday" && num == 34)
        {
            return true;
        }
        else if (day == "Thursday" && num == 0)
        {
            return true;
        }
        else if (day == "Friday" && num % 2 == 0)
        {
            return true;
        }
        else if (day == "Saturday" && num == 56)
        {
            return true;
        }
        else if (day == "Sunday" && (num == 666 || num == -666))
        {
            return true;
        }
        else
        {
            return false;
        }

        // Alternative 1
        //     return new Dictionary<string, Func<int, bool>>() {
        //   { "Monday"    , x => x == 12            },
        //   { "Tuesday"   , x => x > 95             },
        //   { "Wednesday" , x => x == 34            },
        //   { "Thursday"  , x => x == 0             },
        //   { "Friday"    , x => x % 2 == 0         },
        //   { "Saturday"  , x => x == 56            },
        //   { "Sunday"    , x => Math.Abs(x) == 666 }
        // }[day](num);

        // Alternative 2
        // switch (day)
        // {
        //     case "Monday":
        //         return num == 12;
        //     case "Tuesday":
        //         return num > 95;
        //     case "Wednesday":
        //         return num == 34;
        //     case "Thursday":
        //         return num == 0;
        //     case "Friday":
        //         return num % 2 == 0;
        //     case "Saturday":
        //         return num == 56;
        //     case "Sunday":
        //         return num == 666 || num == -666;
        // }
        // return false;
    }

    public static void Main()
    {
        Console.WriteLine(AmIAfraid("Tuesday", 2));
    }
}