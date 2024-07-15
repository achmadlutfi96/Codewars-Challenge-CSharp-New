namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public static int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight){
          //coding and coding..
            int day = 1;
            int grow = UpSpeed;
            while(grow < DesiredHeight){
                grow -= DownSpeed;
                grow += UpSpeed;
                day++;
            }
           return day;

           // Alternative 1
            // return Enumerable.Range(1, 1000).First(x => x * UpSpeed - (x-1) * DownSpeed >= DesiredHeight);
            // Alternative 2
            // return 1+(int)Math.Ceiling(Math.Max((height - up) / (double)(up - down), 0.0));
        }

        public static void Main(){
            Console.WriteLine(GrowingPlant(100,10,910));
            Console.WriteLine(GrowingPlant(10,9,4));
            Console.WriteLine(GrowingPlant(59,48,449));
        }
    }
}