using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Maksim
{
    internal class Ex5
    {
        public static void MatrixMultiply()
        { 
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];
            int[,] C = new int[2, 2];
            Console.Clear();
            Console.WriteLine("Введите 4 числа для первой матрицы A (2x2):");
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = readclass.ReadValue<int>($"A[{i},{j}] = ", int.TryParse);
                }
            }
            Console.WriteLine("Введите 4 числа для второй матрицы В (2х2):");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0;j < 2; j++)
                {
                    B[i, j] = readclass.ReadValue<int>($"B[{i},{j}] = ", int.TryParse);
                }
            }
            C[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0]; 
            C[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            C[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            C[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];

            Console.WriteLine("\nРезультат умножения матриц C = A * B:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

    }
}
