using System;

class JaggedArrayMinMax
{
    static void Main4()
    {
        int[][] arr =
        {
            new int[] { 12, 4, 8 },
            new int[] { 25, 6 },
            new int[] { 3, 18, 10 }
        };

        int largest = arr[0][0];
        int smallest = arr[0][0];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] > largest)
                {
                    largest = arr[i][j];
                }

                if (arr[i][j] < smallest)
                {
                    smallest = arr[i][j];
                }
            }
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Smallest = " + smallest);
    }
}