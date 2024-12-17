using System;
using System.Linq;

public static class Kata
{
    public static bool HasSurvived(int[] attackers, int[] defenders)
    {
        // throw new NotImplementedException();
        if (attackers.Length == 0)
        {
            return true;
        }
        if (defenders.Length == 0)
        {
            return false;
        }
        int[] att = attackers.Where((v, i) => i < defenders.Length ? v > defenders[i] : true).ToArray();
        int[] def = defenders.Where((v, i) => i < attackers.Length ? v > attackers[i] : true).ToArray();
        if (att.Length == def.Length)
        {
            return attackers.Sum() <= defenders.Sum();
        }
        return att.Length < def.Length;

        // Alternative
        // //get difference between defender and attacker
        // int left = D.Length - A.Length;

        // //loop the min value between D and A
        // //accumulate sum
        // //Size: 0	If value is equal to zero
        // //1	If value is greater than zero
        // //-1	If value is lesser than zero
        // for (int i = 0; i < Math.Min(D.Length, A.Length); i++)
        //   left += Math.Sign(D[i] - A[i]);

        // //if left greater or equal to 0 AND defender is more than attacker
        // return left > 0 || left == 0 && D.Sum() >= A.Sum();
    }

    public static void Main()
    {
        Console.WriteLine(HasSurvived(new[] { 1, 3, 5, 7 }, new[] { 2, 4, 6, 8 }));
        Console.WriteLine(HasSurvived(new[] { 2, 9, 9, 7 }, new[] { 1, 1, 3, 8 }));
    }
}