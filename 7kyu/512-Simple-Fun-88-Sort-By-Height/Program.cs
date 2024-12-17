namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public static int[] SortByHeight(int[] a){
          //coding and coding..
          
          for (int i = 0; i < a.Length; i++)
          {
            if(a[i] == -1){
                continue;
            }
            for (int j = i; j < a.Length; j++)
            {
                if(a[j] == -1){
                    continue;
                }
                if(a[j] < a[i]){
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp; 
                }                
            }
          }

          return a;

        //   Alternative
        // Queue<int> sortArr = new(a.Where(x => x != -1).OrderBy(x => x).ToArray());
        //   return a.Select(x => x == -1 ? x : sortArr.Dequeue()).ToArray();
        }

        public static void Main()
        {
            Console.WriteLine(string.Join(", ", SortByHeight(new int[]{-1, 150, 190, 170, -1, -1, 160, 180})));
        }
    }
}