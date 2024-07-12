namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public static bool InviteMoreWomen(int[] L){
          //coding and coding..
          return L.Where(x=>x == -1).Count() < L.Where(x=>x == 1).Count();

          // Alternative
        //   return L.Sum() > 0;
          
        }

        public static void Main(){
            Console.WriteLine(InviteMoreWomen(new int[]{1, -1, 1}));
        }
    }
}