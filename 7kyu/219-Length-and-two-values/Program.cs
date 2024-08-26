public class Kata
{
    public static object[] Alternate(int n, object firstValue, object secondValue)
    {
        object[] result = new object[n];
        for (int i = 0; i < n; i++){
            if(i % 2 == 0){
                result[i] = firstValue;
            }else{
                result[i] = secondValue;
            }
        }
        return result;

        // Alternative
        // return Enumerable.Range(0, n).Select(x => x % 2 == 1 ? secondValue : firstValue).ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", Alternate(5, true, false)));
    }
}