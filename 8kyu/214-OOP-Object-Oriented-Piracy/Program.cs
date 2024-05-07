public class Ship
{
  public int Draft;
  public int Crew;
  
  public Ship(int draft, int crew)
  {
    Draft = draft;
    Crew = crew;
  }
  
  // YOUR CODE HERE...
  public bool IsWorthIt(){
    return Draft-(Crew*1.5) > 20;
  }
}

public class Program{
    public static void Main(string[] args){
        Console.WriteLine(new Ship(100, 20).IsWorthIt());
    }
}