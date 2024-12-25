class Kata
{
    public static string SortTransform(int[] arr)
    {
        //Do Some Magic...
        string first = string.Concat((char)arr[0],(char)arr[1], (char)arr[arr.Length-2], (char)arr[arr.Length-1]);
        Array.Sort(arr);
        string two = string.Concat((char)arr[0],(char)arr[1], (char)arr[arr.Length-2], (char)arr[arr.Length-1]);
        Array.Reverse(arr);
        string three = string.Concat((char)arr[0],(char)arr[1], (char)arr[arr.Length-2], (char)arr[arr.Length-1]);
        Array.Sort(arr);
        string four = string.Concat((char)arr[0],(char)arr[1], (char)arr[arr.Length-2], (char)arr[arr.Length-1]);
        return first+"-"+two+"-"+three+"-"+four;
    }

    public static void Main()
    {
        Console.WriteLine(SortTransform([111, 112, 113, 114, 115, 113, 114, 110]));
    }
}