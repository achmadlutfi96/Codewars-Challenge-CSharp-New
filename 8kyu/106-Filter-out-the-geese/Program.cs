using System.Collections.Generic;
using System.Linq;

public static class Filter
{
  public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
  {
    // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
    string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

    return birds.Except(geese);
  }
  public static void Main(){
    foreach (var item in GooseFilter(new string[] {"Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"}))
    {
        Console.WriteLine(item);
    }
  }
}