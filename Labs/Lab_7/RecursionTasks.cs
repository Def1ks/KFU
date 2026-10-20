using System;

namespace Lab_7
{
    public class RecursionTasks
    {
        // Рекурсивный метод Фибоначчи
        private static int FibRecursive(int n)
        {
            if (n <= 1) return n;
            return FibRecursive(n - 1) + FibRecursive(n - 2);
        }

        // Итеративный метод (цикл)
        private static int FibLoop(int n)
        {
            if (n <= 1) return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        public static void Task3_1()
        {
            Console.WriteLine("--- Задача 3.1 (Фибоначчи) ---");
            Console.Write("Введите номер числа n: ");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                // Ограничим n, чтобы рекурсия не зависла (например, > 30 будет долго считать)
                if (n > 30)
                {
                    Console.WriteLine("Для рекурсии число слишком большое (>30), посчитаем только циклом.");
                    Console.WriteLine($"Цикл: {FibLoop(n)}");
                }
                else
                {
                    Console.WriteLine($"Рекурсия: {FibRecursive(n)}");
                    Console.WriteLine($"Цикл:    {FibLoop(n)}");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное неотрицательное число.");
            }
        }
    }
}