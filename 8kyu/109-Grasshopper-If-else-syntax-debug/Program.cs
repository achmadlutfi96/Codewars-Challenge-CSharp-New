public class Player
{
  private int health = 100;
  public int Health
  {
    get
    {
      return this.health;
    }
    set
    {
      health = value;
    }
  }
  
  public Player()
  {
    
  }
  
  //FIXME: This method won't compile for some reason! :(
  public bool CheckAlive(){
    bool status = false;
    if (this.Health < 0)
    {
      status=false;
    }
    else if (this.Health > 0)
    {
      status=true;
    }
    return status;

    // Alternatif
    // return this.Health > 0 ;

  }
}

public class Program{
    public static void Main(){
        Player greg = new Player();
        greg.Health = 5;
        Console.WriteLine(greg.CheckAlive());
    }
}