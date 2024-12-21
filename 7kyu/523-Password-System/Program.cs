using System.Linq;
public class Crisis
{
    public static string HelpZoom(int[] key)
    {
        return key.Reverse().Select((v,i)=> v == key[i]).All(x=>x==true) ? "Yes" : "No";

        // Alternative
        // return key.Reverse().SequenceEqual(key) ? "Yes" : "No";
    }
}