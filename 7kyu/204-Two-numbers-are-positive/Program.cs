namespace Solution {
    public static class Kata {
        public static bool TwoArePositive(int a, int b, int c) {
            // Happy Coding
            return new int[]{a,b,c}.Where(x=>x>0).Count() == 2;
        }

        public static void Main(){
            Console.WriteLine(TwoArePositive(2, 4, -3));
            Console.WriteLine(TwoArePositive(-14, -3, -4));
        }
    }
}