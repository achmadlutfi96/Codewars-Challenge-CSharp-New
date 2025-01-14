public class LatinSquare
{
    public static int[][] MakeLatinSquare(int n)
    {
        // Make all rows and columns 1, 2, ..., n
        int[][] latinSquare = new int[n][];
        for (int i = 0; i < n; i++)
        {
            latinSquare[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                latinSquare[i][j] = j + 1;
            }
        }

        // Make changes
        // Modify the Latin square if needed
        for (int i = 0; i < n; i++) { 
          latinSquare[i] = new int[n]; 
          for (int j = 0; j < n; j++) { 
            latinSquare[i][j] = (i + j) % n + 1; 
          } 
        }

        return latinSquare;

        // Alternative
        // var arr = Enumerable.Range(1, n).ToArray();
    // return arr.Select(i => arr.Select(j => (i + j) % n + 1).ToArray()).ToArray();
    }
}
