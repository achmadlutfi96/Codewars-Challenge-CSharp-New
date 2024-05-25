public class Kata
{
  public static object Animals(int heads, int legs)
  {
    
    if ((heads > 1) && (legs > 1) &&  (legs % 2 == 0) && (legs <= 1000) && (heads <= 1000)){
      int cow =  (legs/2) - heads;
      int chicken = heads - cow;
      if(cow < 0 || chicken < 0){
        return "No solutions";
      }
      return new int[2]{ chicken , cow};
    }else if(heads == 0 && legs == 0){
      return new int[]{0,0};
    }else{
      return "No solutions";
    }

    // Alternative
    // if (legs % 2 != 0)
    //     return "No solutions";
  
    //   int cows = legs/2 - heads;
    //   int chickens = heads - cows;
      
    //   return (cows < 0 || chickens < 0) ? (object)"No solutions" : new int[2] { chickens, cows };
  }

  public static void Main(){
    foreach (var item in Animals(72, 200).ToString())
    {
        Console.WriteLine(item);
    }
  }
}