class Kata {
    public static string CombineNames(string a, string b){
        return $"{a} {b}";
    }
    public static void Main(String[] args){
        Console.WriteLine(CombineNames("James", "Stevens"));
    }
}