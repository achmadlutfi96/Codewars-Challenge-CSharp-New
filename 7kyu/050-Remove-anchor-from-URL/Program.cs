using System.Linq;
public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    // TODO: complete
    return url.Any(x=>x.Equals('#')) ? url[..url.IndexOf('#')] : url;

    // Alternative
    // return url.Split('#')[0];

  }

  public static void Main(){
    Console.WriteLine(RemoveUrlAnchor("www.codewars.com#about"));
  }
}