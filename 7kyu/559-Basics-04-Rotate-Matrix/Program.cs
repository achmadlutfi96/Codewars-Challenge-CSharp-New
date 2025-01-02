namespace smile67Kata
{
    using System;

    public class Kata
    {
        public static int[,] rotateMatrixLeft(int[,] matrix)
        {
            int[,] res = new int[matrix.GetLength(1),matrix.GetLength(0)];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                   res[i,j] = matrix[j,matrix.GetLength(1)-i-1]; 
                }
            }

            return res;
        }

        public static void Main()
        {
            foreach (var item in rotateMatrixLeft(new int[2, 4] 
            {{-1,4,3,4},
             {5,6,7,8}}))
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
    }
}