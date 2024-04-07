using System;

public static class Game
{
  public static float Combat(float health, float damage)
  {
    // throw new NotImplementedException();

    return health > damage ? health-damage : 0;
    // Alternative
    // return Math.Max(0, health - damage);
  }

  public static void Main(){
    Console.WriteLine(Combat(20, 30));
  }
}