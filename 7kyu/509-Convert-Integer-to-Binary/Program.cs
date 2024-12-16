using System;
public class Converter
{
  public static string ToBinary(int n)
  {
    return Convert.ToString(n, 2);

    // Alternative
    // string rezultbinary = "";
    //         int rezult = 0;
    //         if (n > 0)
    //         {
    //             rezult = n;
    //         }
    //         else
    //         {
    //             rezult = (-1) * n;
    //         }
    //         string binary = "";

    //         while (rezult > 0)
    //         {
    //             binary += (rezult % 2).ToString();
    //             rezult = rezult / 2;
    //         }
    //         char[] t = binary.ToCharArray();

    //         for (int i = (binary.Length - 1); i >= 0; i--)
    //         {
    //             rezultbinary += t[i].ToString();

    //         }

    //         if (n < 0)
    //         {

    //             char[] rezbin = rezultbinary.ToCharArray();
    //             int[] bits = new int[32];
    //             for (int i = 0; i < 32; i++) { bits[i] = 0; }
    //             int p = 31;
    //             for (int i = (rezbin.Length - 1); i >= 0; i--)
    //             {
    //                 bits[p] = (int)Char.GetNumericValue(rezbin[i]);
    //                 p--;
    //             }
    //             for (int i = 0; i < bits.Length; i++)
    //             {
    //                 if (bits[i] == 0) { bits[i] = 1; }
    //                 else { bits[i] = 0; }
    //             }

    //             if ((bits[31] + 1) != 2)
    //             {
    //                 bits[31] = bits[31] + 1;
    //             }
    //             else
    //             {
    //                 bits[31] = 0;
    //                 int rem = 1;
    //                 int i = 30;
    //                 while ((rem == 1) && (i >= 0))
    //                 {
    //                     if ((bits[i] + rem) != 2)
    //                     {
    //                         bits[i] = bits[i] + rem;
    //                         rem = 0;
    //                     }
    //                     else
    //                     {
    //                         bits[i] = 0;
    //                         rem = 1;
    //                     }
    //                     i--;

    //                 }
    //             }

    //             rezultbinary = "";
    //             foreach (int i in bits) { rezultbinary += i.ToString(); }
    //         }
    //         if (n == 0) { rezultbinary = "0"; }
    //         return rezultbinary;
  }

  public static void Main()
  {
    Console.WriteLine(ToBinary(3));
    Console.WriteLine(ToBinary(-3));
  }
}