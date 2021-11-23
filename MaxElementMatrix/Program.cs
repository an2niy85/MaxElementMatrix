using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[,] matrix = new int[size, size];
            Random random = new Random();
            int max = 0;
        
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }

            Console.WriteLine("Элементы исходной матрицы:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]>max)
                    {
                        max = matrix[i, j];                        
                    }
                }
            }
            Console.WriteLine($"\nНаибольший элемент матрицы: {max}");

            Console.WriteLine("\nЭлементы полученной матрицы:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == max)
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
