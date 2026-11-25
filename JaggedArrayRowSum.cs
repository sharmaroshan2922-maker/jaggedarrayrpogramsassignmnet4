using System;

class JaggedArrayRowSum
{
    static void Main6()
    {
        int[][] arr =
        {
            new int[] { 2, 4, 6 },
            new int[] { 5, 5 },
            new int[] { 1, 2, 3, 4 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < arr[i].Length; j++)
            {
                sum = sum + arr[i][j];
            }

            Console.WriteLine("Row " + (i + 1));
            Console.WriteLine("Number of Elements = " + arr[i].Length);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine();
        }
    }
}