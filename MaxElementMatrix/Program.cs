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
            Random rand = new Random();
            int max = 0, k = 0, m = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(9);
                }
            }

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i,j]>max)
                    {
                        max = matrix[i, j];
                        k = i;
                        m = j;
                    }
                }
            }

            Console.WriteLine(max);
            matrix[k, m] = 0;

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
