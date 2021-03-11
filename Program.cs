using System;
using System.IO;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            int N = 3;
            int[,] A = new int[N, N];
            using(StreamReader sr = new StreamReader("Inlet.in"))
            {
                Console.WriteLine("Считаная матрица: ");
                for(int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        A[i, j] = int.Parse(sr.ReadLine().Trim());
                        Console.Write($"{A[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            int mainDia = 0;
            for (int i = 0; i < N; i++)
            {
                mainDia += A[i, i];
            }
            int secondaryDia = 0;
            for (int i = 0, j = N - 1; i < N; i++, j--)
            {
                secondaryDia += A[i, j];
            }
            string result = $"Сумма главной диагонали: {mainDia}\nСумма впомогательной диагонали: {secondaryDia}";
            File.WriteAllText("Outlet.out", result);
        }
    }
}
