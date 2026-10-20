using System;

namespace Lab_7
{
    public class StringTasks
    {
        // Задача 2.1: Удалить символ по индексу
        public static void Task2_1()
        {
            Console.WriteLine("--- Задача 2.1 ---");
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            Console.Write("Введите индекс символа для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index < text.Length)
                {
                    string result = text.Remove(index, 1);
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Индекс выходит за границы строки!");
                }
            }
        }

        // Задача 2.2: Убрать пробелы
        public static void Task2_2()
        {
            Console.WriteLine("\n--- Задача 2.2 ---");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string result = text.Replace(" ", "");
            Console.WriteLine($"Текст без пробелов: {result}");
        }

        // Задача 2.3: Подсчет русских гласных
        public static void Task2_3()
        {
            Console.WriteLine("\n--- Задача 2.3 ---");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine().ToLower(); 

            string vowels = "аеёиоуыэюя";
            int count = 0;

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество русских гласных: {count}");
        }
    }
}