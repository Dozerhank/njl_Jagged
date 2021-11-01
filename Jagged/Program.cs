using System;

namespace Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial user input and jagged initialization
            Console.Write("How many rows are in the jagged array? ");
            int rowTotal = Convert.ToInt32(Console.ReadLine());
            int[][] jagged = new int[rowTotal][];

            //Place user input data in jagged array
            for (int i = 0; i < rowTotal; i++)
            {
                Console.Write("Enter a row, separated by spaces: ");
                string temp = Console.ReadLine();
                string[] row = temp.Split(' ');
                int[] finalRow = Array.ConvertAll(row, int.Parse);
                jagged[i] = new int[finalRow.Length];

                for (int j = 0; j < finalRow.Length; j++)
                {
                    jagged[i][j] = finalRow[j];
                }
            }

            //Output data
            Console.WriteLine("After the funky operation, the resulting array is: ");
            for (int i = 0; i < rowTotal; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write("{0, 5}", jagged[i][j] * (i + j + 1));
                }
                Console.WriteLine("");
            }
        }
    }
}