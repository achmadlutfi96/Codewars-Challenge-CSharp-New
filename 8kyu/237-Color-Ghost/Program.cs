using System;

public class Ghost
{
  public string Color { get; set; } = "white";
  public string GetColor(){
    string[] str = new string[]{"white", "purple", "red", "yellow"};
    return str[new Random().Next(str.Length)];
  }
}

public class Program{
    public static void Main(string[] args){
        Console.WriteLine(new Ghost().Color);
    }
}