using System;

namespace Lab_7
{
    public class ArithmeticTasks
    {
        // Задача 1.1: |n - 48|, если n > 48 -> * 3
        public static void Task1_1()
        {
            Console.WriteLine("--- Задача 1.1 ---");
            Console.Write("Введите целое число n: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = Math.Abs(n - 48);

                if (n > 48)
                {
                    result *= 3;
                    Console.WriteLine($"n > 48, результат утроен: {result}");
                }
                else
                {
                    Console.WriteLine($"Результат |n - 48|: {result}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
            }
        }

        // Задача 1.2: Сумма и произведение цифр
        public static void Task1_2()
        {
            Console.WriteLine("\n--- Задача 1.2 ---");
            Console.Write("Введите неотрицательное число: ");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int sum = 0;
                long product = 1; 

                if (n == 0)
                {
                    sum = 0;
                    product = 0;
                }
                else
                {
                    int temp = n;
                    while (temp > 0)
                    {
                        int digit = temp % 10;
                        sum += digit;
                        product *= digit;
                        temp /= 10;
                    }
                }

                Console.WriteLine($"Сумма цифр: {sum}");
                Console.WriteLine($"Произведение цифр: {product}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите неотрицательное число.");
            }
        }

        // Задача 1.3: Делится ли на 3 и 5
        public static void Task1_3()
        {
            Console.WriteLine("\n--- Задача 1.3 ---");
            Console.Write("Введите целое число: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                bool isDivisible = (n % 3 == 0) && (n % 5 == 0);

                if (isDivisible)
                    Console.WriteLine($"Число {n} делится одновременно на 3 и 5.");
                else
                    Console.WriteLine($"Число {n} НЕ делится одновременно на 3 и 5.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
            }
        }
    }
}