using System;

namespace Test_14_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[N]; 
            int[][] a = new int[N][];
            for (int i = 0; i < N; i++)
            {
                A = new int[N];
                Console.WriteLine("Масив " + (i+1));
                for (int j = 0; j < N; j++)
                {
                    A[j] = Convert.ToInt32(Console.ReadLine()); 
                }
                a[i] = A;
            }
            Console.Clear();

            Console.Write("[");
            for (int i = 0; i < N; i++)
            {
                Console.Write("[");
                for (int j = 0; j < N; j++)
                {
                    Console.Write(a[i][j]);
                    if (j != N - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
            }
            Console.WriteLine("]");

            N -= 1;

            for (int i = 0; i < N; i++)
            {
                if(Math.Abs(a[i][N]) >= Math.Abs(a[i + 1][0])&&a[i][N]<0)
                {
                    a[i][N] *= -1;
                    a[i + 1][0] *= -1;
                }
                else if (Math.Abs(a[i][N]) <= Math.Abs(a[i + 1][0]) && a[i+1][0] < 0)
                {
                    a[i][N] *= -1;
                    a[i + 1][0] *= -1;
                }
            }

            int Max = 0;
            Console.Write("[");
            for (int i = 0; i <= N; i++)
            {
                Console.Write("[");
                for (int j = 0; j <= N; j++)
                {
                    Max += a[i][j];
                    Console.Write(a[i][j]);
                    if (j != N)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
            }
            Console.WriteLine("]");

            Console.WriteLine("Максимум равен = " + Max);
        }
    }
}
