public class PartList
{
    public static string[][] Partlist(string[] arr)
    {
        // your code
        string[][] res = new string[arr.Length - 1][];
        for (int i = 0; i < arr.Length-1; i++)
        {   
            string[] temp = new string[2];
            temp[0] = string.Join(" ", arr, 0, i+1);
            temp[1] = string.Join(" ", arr, i+1 , arr.Length-i-1);
            res[i] = temp;
        }
        return res;

        // Alternative
        // return arr.Select((s, i) => new[] {string.Join(" ", arr.Take(i)), string.Join(" ", arr.Skip(i))}).Skip(1).ToArray();
    }

    public static void Main()
    {
        foreach (var i in Partlist(new String[] { "vJQ", "anj", "mQDq", "sOZ" }))
        {
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
        }
    }
}