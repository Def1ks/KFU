using System;

namespace Lab_7
{
    public class BinaryTasks
    {
        // Рекурсивный перевод в двоичную
        private static string ToBinary(int n)
        {
            if (n < 2) return n.ToString();
            return ToBinary(n / 2) + (n % 2).ToString();
        }

        public static void Task4_1()
        {
            Console.WriteLine("--- Задача 4.1 (В двоичную) ---");
            Console.Write("Введите неотрицательное число: ");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                string binary = ToBinary(n);
                Console.WriteLine($"Двоичное представление: {binary}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}