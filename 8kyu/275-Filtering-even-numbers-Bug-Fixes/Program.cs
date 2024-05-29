using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i]%2 == 0)
                {
                    listOfNumbers.RemoveAt(i);
                    i--;
                }
            }
            return listOfNumbers;

            // Alternative
            // return numbers.Where(n => n % 2 == 1).ToList();
        }

        public static void Main(){
            foreach (var item in FilterOddNumber(new List<int>() {1, 2, 2, 2, 4, 3, 4, 5, 6, 7}))
            {
                Console.WriteLine(item);
            }
        }
    }