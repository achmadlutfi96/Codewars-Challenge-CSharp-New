// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    //Your code goes here...
    int score = (s1+s2+s3)/3;
    if(90 <= score) return 'A';
    else if (80 <= score) return 'B';
    else if (70 <= score) return 'C';
    else if (60 <= score) return 'D';
    else return 'F';
  }
  public static void Main(){
    Console.WriteLine(GetGrade(95,90,93));
  }
}