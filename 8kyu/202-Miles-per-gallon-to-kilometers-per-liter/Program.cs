using System;
public static class Kata
{
	public static double Converter(int mpg)
	{
		// do your magic
        return Math.Round(mpg * (1.609344/4.54609188), 2);
	}

    public static void Main(){
        Console.WriteLine(Converter(12));
    }
}