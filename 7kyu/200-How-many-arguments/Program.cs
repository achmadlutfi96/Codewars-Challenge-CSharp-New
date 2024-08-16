public static class Kata {
    // Create a function called CountArgs that returns the number of arguments provided (as an int)
    public static int CountArgs(params object[] args){
        return args.Length;
    }

    public static void Main(){
        Console.WriteLine(CountArgs('a', 865, "asfhgajsf", new object[] { "dawdjio", null, new List<object>() }));
    }
}
