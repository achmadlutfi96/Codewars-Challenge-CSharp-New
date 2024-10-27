public static class Kata
{
    // * PRELOADED:
    public enum Value { Scissors, Paper, Rock, Lizard, Spock }
    public enum Ordering { LT, EQ, GT }

    public static Ordering Rpsls(Value a, Value b)
    {
        if (a == b)
        {
            return Ordering.EQ;
        }
        else if (
            (a == Value.Scissors && b == Value.Paper) ||
            (a == Value.Paper && b == Value.Rock) ||
            (a == Value.Rock && b == Value.Lizard) ||
            (a == Value.Lizard && b == Value.Spock) ||
            (a == Value.Spock && b == Value.Scissors) ||
            (a == Value.Scissors && b == Value.Lizard) ||
            (a == Value.Lizard && b == Value.Paper) ||
            (a == Value.Paper && b == Value.Spock) ||
            (a == Value.Spock && b == Value.Rock) ||
            (a == Value.Rock && b == Value.Scissors)
        )
        {
            return Ordering.GT;
        }else{
            return Ordering.LT;
        } 

        // Alternative 
        // return ((a - b + 4) % 5) switch
        // {
        //     0 or 2 => Ordering.LT,
        //     1 or 3 => Ordering.GT,
        //     4 => Ordering.EQ
        // };
    }

    public static void Main()
    {
        Console.WriteLine(Rpsls(Value.Rock, Value.Lizard));
    }
}