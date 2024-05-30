using System;
using System.Collections.Generic;

public class AddMore
{
    public static List<int> AddExtra(List<int> listOfNumbers)
    {
        // your code here
        // add an int to listOfNumbers and return it
        List<int> nlist = new List<int>();
          foreach(int i in listOfNumbers){
            nlist.Add(i);
          }
        nlist.Add(9);
        return nlist;

        // Alternative
        // return new List<int>(listOfNumbers){9};
    }

    public static void Main(){
        foreach (var item in AddExtra(new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 }))
        {
            Console.WriteLine(item.ToString());
        }
    }
}