using System;
using System.Linq;
public static class Kata
{

    /*
If you look down the middle of the triangle, you will see square numbers (you don't see them on even rows) like
1, 4, 9, 16, 25, 36...
  
             1                 <-- middle number is 1
          3     5              <-- middle number is 4
       7     9    11           <-- middle number is 9
   13    15     17    19       <-- middle number is 16
21    23    25     27    29    <-- middle number is 25

The middle number is also the average of the row numbers
 * The average of the second row is 4: (3+5)/2
 * The average of the third  row is 9: (7+9+11)/3

To work out the sum of a sequence we can multiply the average by the number of terms in the sequence

Notice that the second row has 2 terms, the third row has 3 terms, the Nth row has N terms
 
So to find a sum of a row we can multiply the average (the square of the row number) by the number of terms 
(also the row number)

This means that the answer is actually simply the cube (power 3) of the row number
  
  */
  public static long RowSumOddNumbers(long n)
  {
    // TODO
    if(n == 1){
        return 1;
    }
    int start = Enumerable.Range(1, (int)n-1).Select(x=>x*2).Sum();
    return Enumerable.Range(start, (int)n*2).Where(x=>x%2 == 1).Sum();

    // Alternative
    // return Math.Pow(n,3);
  }

  public static void Main(){
    Console.WriteLine(RowSumOddNumbers(3));
  }
}