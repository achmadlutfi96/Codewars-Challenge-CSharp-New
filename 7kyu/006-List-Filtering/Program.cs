using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      return listOfItems.OfType<int>();
   }

   public static void Main(){
    foreach (var item in GetIntegersFromList(new List<object>(){1,"a","b",0,15}))
    {
        Console.WriteLine(item);
    }
   }
}