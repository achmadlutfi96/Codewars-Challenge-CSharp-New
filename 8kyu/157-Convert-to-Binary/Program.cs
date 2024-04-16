using System;

public static class Kata
{
  public static int ToBinary(int n)
  {
    // throw new NotImplementedException();
    return Convert.ToInt32(Convert.ToString(n, 2));

    // Alternative
    // int q=n,tmp=0,m=1;
    // while(q!=0)
    // {
    //   tmp+=q%2*m;
    //   q=q/2;
    //   m*=10;
    // }
    // return tmp;

  }

  public static void Main(){
    Console.WriteLine(ToBinary(5));
  }
}