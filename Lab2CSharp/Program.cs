using System;

namespace ArrayTasks
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            Task1_1D();

            Console.WriteLine("\nTask 1.2");
            Task1_2D();

            Console.WriteLine("\nTask 2");
            Task2();

            Console.WriteLine("\nTask 3");
            Task3();

            Console.WriteLine("\nTask 4");
            Task4();
        }

        static void Task1_1D()
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] arr = new int[n];

            Console.WriteLine("Generated array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Indices of elements not divisible by 2 and 3: ");
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] % 3 != 0)
                {
                    Console.Write(i + " ");
                    found = true;
                }
            }
            if (!found) Console.Write("None");
            Console.WriteLine();
        }

        static void Task1_2D()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("Enter number of cols: ");
            int cols = int.Parse(Console.ReadLine()!);

            int[,] arr = new int[rows, cols];

            Console.WriteLine("Generated matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rnd.Next(1, 100);
                    Console.Write(arr[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.Write("Indices of elements not divisible by 2 and 3: ");
            bool found = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] % 2 != 0 && arr[i, j] % 3 != 0)
                    {
                        Console.Write($"[{i},{j}] ");
                        found = true;
                    }
                }
            }
            if (!found) Console.Write("None");
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine()!);
            double[] arr = new double[n];

            Console.WriteLine("Generated array:");
            double maxModulus = -1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = (rnd.NextDouble() * 200) - 100;
                Console.Write($"{arr[i]:F2}  ");

                if (Math.Abs(arr[i]) > maxModulus)
                {
                    maxModulus = Math.Abs(arr[i]);
                }
            }
            Console.WriteLine($"\nMaximum absolute value: {maxModulus:F2}");
        }

        static void Task3()
        {
            Console.Write("Enter size n of the matrix and vector: ");
            int n = int.Parse(Console.ReadLine()!);

            int[,] A = new int[n, n];
            int[] X = new int[n];
            int[] Y = new int[n];

            Console.WriteLine("Matrix A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(1, 10);
                    Console.Write(A[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            Console.WriteLine("Vector X:");
            for (int i = 0; i < n; i++)
            {
                X[i] = rnd.Next(1, 10);
                Console.Write(X[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Y[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    Y[i] += A[i, j] * X[j];
                }
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Y[i] + " ");
            }
            Console.WriteLine();
        }

        static void Task4()
        {
            Console.Write("Enter number of rows: ");
            int n = int.Parse(Console.ReadLine()!);

            int[][] jagged = new int[n][];

            Console.WriteLine("Original array:");
            for (int i = 0; i < n; i++)
            {
                int m = rnd.Next(3, 7);
                jagged[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    jagged[i][j] = rnd.Next(1, 10);
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Enter size of vector: ");
            int xSize = int.Parse(Console.ReadLine()!);
            int[] x = new int[xSize];
            Console.Write("Vector x: ");
            for (int i = 0; i < xSize; i++)
            {
                x[i] = rnd.Next(90, 100);
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();

            for (int i = 1; i < n; i += 2)
            {
                jagged[i] = (int[])x.Clone();
            }

            Console.WriteLine("\nModified Array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
