/* left blank for unlimited creativity :) */
class Kata {
    public static Func<int, int[]> MultiplyAll(int[] n){
        return (int m) => n.Select(x=>x*m).ToArray();
    }

    public static void Main(){
        foreach (var item in MultiplyAll(new int[] {1, 2, 3})(2))
        {
            Console.WriteLine(item);
        }
    }
}