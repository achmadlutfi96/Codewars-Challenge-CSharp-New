using System;

public class Kata
{
  public static void If(bool condition, Action func1, Action func2)
  {
    // ...
    if(condition){
        func1();
    }else{
        func2();
    }

    // Alternative
    // (condition ? func1 : func2)();
  }

  public static void Main(){
    bool a = true;
    If(false, () => a = true, () => a = false);

    Console.WriteLine($"{a}");
  }
}