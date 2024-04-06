using System;

public static class Kata
{
  public static int GetRealFloor(int n)
  {
    // throw new NotImplementedException();
    if (n > 13)
    {
        return n-2;
    }else if(n > 1){
        return n-1;
    }else if(n==1){
        return 0;
    }else{
        return n;
    }
    // Alternative
    // return n < 1 ? n : n > 13 ? n -2 : n- 1;
  }
  public static void Main(){
    Console.WriteLine(GetRealFloor(1));
    Console.WriteLine(GetRealFloor(5));
    Console.WriteLine(GetRealFloor(15));
  }
}