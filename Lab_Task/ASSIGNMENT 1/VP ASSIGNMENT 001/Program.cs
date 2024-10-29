using System;

namespace MatrixDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the 3x3x3 matrix
            int[,,] matrix = new int[3, 3, 3];

            // Input values into the matrix
            Console.WriteLine("Enter the values for the 3x3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write($"matrix[{i},{j},{k}] = ");
                        matrix[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }

            // Sum the values on the diagonals
            int diagonalSum = 0;
            for (int i = 0; i < 3; i++)
            {
                diagonalSum += matrix[i, i, i];
            }

            // Output the result
            Console.WriteLine($"The sum of the values on the main diagonal is: {diagonalSum}");
        }
    }
}

