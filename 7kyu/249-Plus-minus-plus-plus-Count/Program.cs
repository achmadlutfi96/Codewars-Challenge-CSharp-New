namespace Solution
{
    public class Kata
    {
        public static int CatchSignChange(int[] arr)
        {
            int result = 0;
            bool first = false;
            bool second = false;
            for(int i = 1; i < arr.Length; i++){
                first = arr[i-1] >= 0;
                second = arr[i] >= 0;
                if(first != second){
                    result++;
                }
            }
            return result;

            // Alternative
            // return arr.Zip(arr.Skip(1), (x, y) => x >= 0 && y >= 0 || x < 0 && y < 0 ? 0 : 1).Sum();

        }

        public static void Main(){
            Console.WriteLine(CatchSignChange(new int[] { 1, -3, -4, 0, 5 }));
        }
    }
}