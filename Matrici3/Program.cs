using System;

namespace Matrici3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr de linii=  ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr de coloane=  ");
            int M1 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[N1, M1];
            Console.Write("Nr de linii=  ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr de coloane=  ");
            int M2 = Convert.ToInt32(Console.ReadLine());
            int[,] B = new int[N2, M2];

            Console.Write("Elementele matricii A :\n");
            for (int i = 0; i < N1; i++)
            {
                for (int j = 0; j < M1; j++)
                {
                    Console.Write($"[{i}],[{j}] : ");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Elementele matricii B :\n");
            for (int i = 0; i < N2; i++)
            {
                for (int j = 0; j < M2; j++)
                {
                    Console.Write($"[{i}],[{j}] : ");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int temp = 0;
            int [,] matrix = new int[N1, M2];
            if (M1 != N2)
            {
                Console.WriteLine("matrix can't be multiplied !!");
            }
            else
            {
                for (int i = 0; i < N1; i++)
                {
                    for (int j = 0; j < M2; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < N2; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        matrix[i, j] = temp;
                    }
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j] + " ");
                       
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
