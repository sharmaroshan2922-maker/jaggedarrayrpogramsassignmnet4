using System;

class JaggedArrayInput
{
    static void Main2()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        int[][] arr = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write("Enter size of row " + i + ": ");
            int size = int.Parse(Console.ReadLine());

            arr[i] = new int[size];

            for (int j = 0; j < size; j++)
            {
                Console.Write("Enter element: ");
                arr[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged Array:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}