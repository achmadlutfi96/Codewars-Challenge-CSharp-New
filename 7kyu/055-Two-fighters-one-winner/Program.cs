public class Kata {
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) {
    // Your code goes here. Have fun!
    Fighter first;
    Fighter second;

    if(firstAttacker == fighter1.Name) {
        first = fighter1;
        second = fighter2;
        while(first.Health > 0 || second.Health > 0){
            second.Health -= first.DamagePerAttack;
            if(second.Health <= 0) {
                return first.Name;
            }
            first.Health -= second.DamagePerAttack;
            if (first.Health <= 0) {
                return second.Name;
            }
        }
    }else{
        first = fighter2;
        second = fighter1;
        while(first.Health > 0 || second.Health > 0){
            second.Health -= first.DamagePerAttack;
            if(second.Health <= 0) {
                return first.Name;
            }
            first.Health -= second.DamagePerAttack;
            if (first.Health <= 0) {
                return second.Name;
            }
        }
    }

    return first.Name;

    // Alternative
    // Fighter attacker = (firstAttacker == fighter1.Name) ?  fighter1 : fighter2;
    // Fighter defender = (firstAttacker == fighter1.Name) ? fighter2 : fighter1;
    
    // while ((attacker.Health > 0) && (defender.Health > 0))
    // {
    // 		defender.Health -= attacker.DamagePerAttack;
    //     if(defender.Health > 0)
    //     {
    //     		attacker.Health -= defender.DamagePerAttack;
    //     }
    // }
    
    // return (attacker.Health > defender.Health) ? attacker.Name : defender.Name;
  }

  public static void Main(){
    Console.WriteLine(declareWinner(new Fighter("Lew", 10, 2),new Fighter("Harry", 5, 4), "Lew"));
  }
}

public class Fighter {
  public string Name;
  public int Health, DamagePerAttack;
  public Fighter(string name, int health, int damagePerAttack) {
    this.Name = name;
    this.Health = health;
    this.DamagePerAttack = damagePerAttack;
  }
}