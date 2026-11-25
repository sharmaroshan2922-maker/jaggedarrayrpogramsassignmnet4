using System;

class JaggedArraySearch
{
    static void Main7()
    {
        int[][] arr =
        {
            new int[] { 10, 20, 30 },
            new int[] { 40, 50 },
            new int[] { 60, 70, 80 }
        };

        Console.Write("Enter element to search: ");
        int key = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == key)
                {
                    Console.WriteLine(
                        "Element found at Row " + (i + 1) +
                        ", Column " + (j + 1)
                    );

                    found = true;
                }
            }
        }

        if (found == false)
        {
            Console.WriteLine("Element not found.");
        }
    }
}