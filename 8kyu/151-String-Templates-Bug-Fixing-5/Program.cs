using System;

public static class Kata 
{
    public static string buildString(string[] args)
    {
      return String.Format("I like {0}!", String.Join(", ", args));
    }

    public static void Main(){
        Console.WriteLine(buildString(new string[] {"Cheese","Milk","Chocolate"}));
    }
}