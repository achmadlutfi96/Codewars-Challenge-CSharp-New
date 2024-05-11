using System;

public static class Kata
{
  public static string Quote(string fighter)
  {
    // throw new NotImplementedException();
    return fighter.ToLower() switch 
    {
        "george saint pierre"=>"I am not impressed by your performance.",
        "conor mcgregor" => "I'd like to take this chance to apologize.. To absolutely NOBODY!",
        _ => ""
    };
  }

  public static void Main(){
    Console.WriteLine(Quote("george saint pierre"));
  }
}