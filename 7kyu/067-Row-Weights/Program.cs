class Kata
{
    public static int[] RowWeights(int[] a)
    {
        //Do Some Magic
        return new int[] {a.Where((v, i)=> (i+1)%2 == 1).Sum(), a.Where((v, i)=> (i+1)%2 == 0).Sum()}; 

        // Alternative
        // return new int[]
            // {
            //     numbers.Where((n, index) => index % 2 == 0).Sum(),
            //     numbers.Where((n, index) => index % 2 == 1).Sum()
            // };
    }

    public static void Main(){
        foreach(var item in RowWeights(new int[]{13, 27, 49})){
            Console.WriteLine(item);
        }
    }
}