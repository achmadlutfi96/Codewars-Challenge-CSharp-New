using System.Collections.Generic;
using System;
using System.Linq;
public class Kata
{
  public static int Gcd(int a, int b)
  {
    int first , second;

    if(a > b){
        first = a;
        second = b;
    } else{
        first = b;
        second = a;
    }

    while(second > 0){
        int temp = first%second;
        first = second;
        second = temp;
    }
    
    return first;

    // Alternative 1
    // return a % b == 0 ? b : Gcd (b, a % b);

    // Alternative 2
    // while(b!=0){
    //   (a,b) = (b,a%b);
    // }
    // return a;
  }

  public static void Main(){
    Console.WriteLine(Gcd(30, 12));
    Console.WriteLine(Gcd(8, 9));
  }
}