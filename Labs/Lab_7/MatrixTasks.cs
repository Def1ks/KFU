using System;

namespace Lab_7
{
    public class MatrixTasks
    {
        public static void Task5_1()
        {
            Console.WriteLine("--- Задача 5.1 (Матрица NxN) ---");
            Console.Write("Введите размер матрицы N (нечетное от 3 до 9): ");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= 3 && n <= 9 && n % 2 != 0)
            {
                int[,] matrix = new int[n, n];
                Random rand = new Random();

                // 1. Заполнение и вывод матрицы
                Console.WriteLine("Сгенерированная матрица:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = rand.Next(1, 100); // Числа от 1 до 99
                        Console.Write($"{matrix[i, j],4}");
                    }
                    Console.WriteLine();
                }

                // 2. Прямой и косой крест
                Console.WriteLine("\nЭлементы креста (остальные заменим на '.'):");
                int center = n / 2;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        bool isCross = (i == center || j == center) || (i == j || i + j == n - 1);
                        if (isCross)
                            Console.Write($"{matrix[i, j],4}");
                        else
                            Console.Write($"{" .",4}");
                    }
                    Console.WriteLine();
                }

                // 3. Максимум в каждой строке
                Console.WriteLine("\nМаксимальные элементы в строках:");
                for (int i = 0; i < n; i++)
                {
                    int max = matrix[i, 0];
                    for (int j = 1; j < n; j++)
                    {
                        if (matrix[i, j] > max) max = matrix[i, j];
                    }
                    Console.WriteLine($"Строка {i}: {max}");
                }

                // 4. Сумма главной диагонали
                int diagSum = 0;
                for (int i = 0; i < n; i++)
                {
                    diagSum += matrix[i, i];
                }
                Console.WriteLine($"\nСумма главной диагонали: {diagSum}");

                // 5. Максимальный элемент всей матрицы и его координаты
                int globalMax = matrix[0, 0];
                int maxRow = 0, maxCol = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] > globalMax)
                        {
                            globalMax = matrix[i, j];
                            maxRow = i;
                            maxCol = j;
                        }
                    }
                }
                Console.WriteLine($"Максимальный элемент: {globalMax} [{maxRow}, {maxCol}]");
            }
            else
            {
                Console.WriteLine("Ошибка! N должно быть нечетным числом от 3 до 9.");
            }
        }
    }
}