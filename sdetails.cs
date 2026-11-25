using System;

class SDetails
{
    static void Main()
    {
        int[][] marks = new int[3][];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter number of subjects for Student " + (i + 1) + ": ");
            int subjects = int.Parse(Console.ReadLine());

            marks[i] = new int[subjects];

            for (int j = 0; j < subjects; j++)
            {
                Console.Write("Enter marks of Subject " + (j + 1) + ": ");
                marks[i][j] = int.Parse(Console.ReadLine());
            }
        }

        
        Console.WriteLine("\n--- Student Details ---");

        for (int i = 0; i < 3; i++)
        {
            int total = 0;

            for (int j = 0; j < marks[i].Length; j++)
            {
                total = total + marks[i][j];
            }

            double percentage = (double)total / marks[i].Length;

            Console.WriteLine("\nStudent " + (i + 1));
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + percentage + "%");
        }
    }
}