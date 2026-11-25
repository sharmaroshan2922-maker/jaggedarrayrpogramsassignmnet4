using System;

class JaggedArrayRows
{
    static void Main5()
    {
        int[][] arr =
        {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");

            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}