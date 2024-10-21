namespace Solution
{
    public class Kata
    {
        public static int LeastLarger(int[] a, int i)
        {
            int n = a.Where(x=>x>a[i]).OrderBy(x=>x).FirstOrDefault();
            return a.Where(x=>x>a[i]).Count() > 0 ? Array.IndexOf(a, n) : -1;

            // Alternative
            // return Array.IndexOf(a, a.Min(x => x > a[i] ? x : null));
        }

        public static void Main(){
            Console.WriteLine(LeastLarger(new[] { 4, 1, 3, 5, 6 }, 0));
            Console.WriteLine(LeastLarger(new[] { 4, 1, 3, 5, 6 }, 4));
        }
    }
}