using System;
using System.Linq;
using System.Text.RegularExpressions;

class Kata
{
    public static string SpecialNumber(int number)
    {
        //Do Some Magic
        return number.ToString().Select(x=>char.GetNumericValue(x) > 5 ? false : true).All(x=>x==true) ? "Special!!" : "NOT!!";

        // Alternative
        // return Regex.IsMatch(number.ToString(), "[^0-5]") ? "NOT!!" : "Special!!";
    }

    public static void Main(){
        Console.WriteLine(SpecialNumber(00011));
    }
}