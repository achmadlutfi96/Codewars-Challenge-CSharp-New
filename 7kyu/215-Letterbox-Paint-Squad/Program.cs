using System.Collections.Generic;

public class Kata
{
    public static IEnumerable<int> PaintLetterBoxes(int start, int end)
    {
        // Your code here
        List<int> rangeNumbers = Enumerable.Range(start, end - start + 1).ToList();
        List<int> letterBoxes = new List<int>();
        foreach (var number in rangeNumbers)
        {
            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                letterBoxes.Add((int)char.GetNumericValue(numberString[i]));
            }
        }
        return Enumerable.Range(0, 10).Select(x => letterBoxes.Where(y => x == y).Count());

        // Alternative
        // return ("0123456789" + string.Concat(Enumerable.Range(start, end - start + 1)))
        // .GroupBy(c => c)
        // .Select(x => x.Count() - 1);
    }

    public static void Main()
    {
        foreach (var item in PaintLetterBoxes(125, 132))
        {
            Console.WriteLine(item);
        }
    }
}