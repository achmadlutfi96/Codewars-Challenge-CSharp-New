public class Kata
{
    public static string Uncensor(string infected, string discovered)
    {
        string res = "";
        int i = 0;
        foreach (char item in infected)
        {
            if (item == '*'){
                res += discovered[i];
                i++;
            }else{
                res += item;
            }
            
        }
        return res;

        // Alternative
        // return string.Concat(infected.Select(c => c == '*' ? discovered[i++] : c));
    }

    public static void Main()
    {
        Console.WriteLine(Uncensor("*h*s *s v*ry *tr*ng*", "Tiiesae"));
    }
}