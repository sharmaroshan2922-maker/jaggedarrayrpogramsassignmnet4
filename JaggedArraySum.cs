using System;

class JaggedArraySum
{
    static void Main3()
    {
        int[][] arr =
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8 }
        };

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                sum = sum + arr[i][j];
            }
        }

        Console.WriteLine("Sum = " + sum);
    }
}