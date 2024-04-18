using System;

public static class AgeDiff
{
    public static string CalculateAge(int birth, int yearTo)
    {
        int age = yearTo-birth;
        if(age == 0){
            return "You were born this very year!";
        }else if(age > 0){
            string plural = age==1? "year": "years";
            return $"You are {age} {plural} old.";
        }else{
            age = Math.Abs(age);
            string plural = age==1? "year": "years";
            return $"You will be born in {age} {plural}.";
        }
        
        // Alternative
        // return (yearTo - birth) switch
        // {
        //     0 => "You were born this very year!",
        //     1 => "You are 1 year old.",
        //     >1 => $"You are {yearTo - birth} years old.",
        //     -1 => "You will be born in 1 year.",
        //     _ => $"You will be born in {birth - yearTo} years."
        // };
    }
    public static void Main()
    {
        Console.WriteLine(CalculateAge(2019, 2020));
    }
}