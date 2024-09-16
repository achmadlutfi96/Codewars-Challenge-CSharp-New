public class Kata
{
  public static string ReplaceNth(string text, int n, char oldValue, char newValue)
  {
    if(n < 1){
      return text;
    }
    List<char> results = new();
    int index = 0;
    foreach (char c in text)
    {
        if(c == oldValue){
            index++;
        }
        if(index%n == 0 && c == oldValue){
            results.Add(newValue);
        }else{
            results.Add(c);
        }
    }
    return string.Concat(results);

    // Alternative
    // return Regex.Replace(text, $"{oldValue}", m => n > 0 && ++i % n == 0 ? $"{newValue}" : m.Value);
  }

  public static void Main(){
    Console.WriteLine(ReplaceNth("Vader said: No, I am your father!", 2, 'a', 'o'));
  }
}