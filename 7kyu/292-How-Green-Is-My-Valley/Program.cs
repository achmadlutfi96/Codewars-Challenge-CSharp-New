using System.Collections.Generic;
public class Valley
{

    public static int[] MakeValley(int[] arr)
    {
        // your code
        Array.Sort(arr);
        Array.Reverse(arr);
        Queue<int> arr1 = new();
        Stack<int> arr2 = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                arr1.Enqueue(arr[i]);
            }
            else
            {
                arr2.Push(arr[i]);
            }
        }
        return arr1.Concat(arr2).ToArray();

        // Alternative
        // var leftList = new List<int>();
        // var rightList = new List<int>();
        // var inputList = arr.ToList();
        // inputList.Sort();
        // var counter = inputList.Count - 1;
        // while (counter >= 0)
        // {
        // 	leftList.Add(inputList[counter]);
        // 	counter--;
        // 	if (counter >= 0)
        // 	{
        // 		rightList.Add(inputList[counter]);
        // 	}
        // 	counter--;
        // }
        // rightList.Reverse();
        // leftList.AddRange(rightList);
        // return leftList.ToArray();

    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", MakeValley(new int[] { 17, 17, 15, 14, 8, 7, 7, 5, 4, 4, 1 })));
    }
}