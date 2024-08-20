public class Kata
{
  public static string BandNameGenerator(string str)
  {
    // Happy coding
    if(str.First() == str.Last()){
        return string.Concat(char.ToUpper(str[0]),str.Substring(1),str.Substring(1));
    }else{
        return $"The {char.ToUpper(str[0])}{str.Substring(1)}";
    }

    // Alternative 1
    // return (str[0] != str[^1] ? $"The {char.ToUpper(str[0])}" : char.ToUpper(str[0]) + str[1..]) + str[1..];

    // Alternative 2
    // return str.First()==str[str.Length-1] ? str.First().ToString().ToUpper()+str.Substring(1)+str.Substring(1) : "The"+" "+str.First().ToString().ToUpper()+str.Substring(1);
  }

  public static void Main(){
    Console.WriteLine(BandNameGenerator("knife"));
    Console.WriteLine(BandNameGenerator("tart"));
  }
}