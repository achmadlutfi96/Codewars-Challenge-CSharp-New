using System;

public class Ball {
  public string ballType { get; set; }
  
  public Ball(string ballType = "regular") {
    // your code goes here
    this.ballType = ballType;
  }

}

public class Program{
    public static void Main(string[] args) {
        Console.WriteLine(new Ball().ballType);
        Console.WriteLine(new Ball("super").ballType);
    }
}