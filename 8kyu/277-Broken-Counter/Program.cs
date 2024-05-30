public class Counter
{
    private int _Value;
  public int Value
  {
    get
    {
      return _Value;
    }
    private set
    {
      _Value = value;
    }
  }
  
  public Counter()
  {
    Value = 0;
  }
  
  public void Increase()
  {
    ++Value;
  }
  
  public void Reset()
  {
    Value = 0;
  }
}

class Program {
    public static void Main(string[] args){
        Counter counter = new Counter();
        Console.WriteLine(counter.Value);
        counter.Increase();
        Console.WriteLine(counter.Value);
        counter.Reset();
        Console.WriteLine(counter.Value);
    }
}