using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("МЕНЮ");
                Console.WriteLine("1. Арифметика (1.1 - 1.3)");
                Console.WriteLine("2. Строки (2.1 - 2.3)");
                Console.WriteLine("3. Рекурсия (3.1)");
                Console.WriteLine("4. Системы счисления (4.1)");
                Console.WriteLine("5. Матрицы (5.1)");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ArithmeticTasks.Task1_1();
                        ArithmeticTasks.Task1_2();
                        ArithmeticTasks.Task1_3();
                        break;
                    case "2":
                        StringTasks.Task2_1();
                        StringTasks.Task2_2();
                        StringTasks.Task2_3();
                        break;
                    case "3":
                        RecursionTasks.Task3_1();
                        break;
                    case "4":
                        BinaryTasks.Task4_1();
                        break;
                    case "5":
                        MatrixTasks.Task5_1();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }

                Console.WriteLine("\nНажмите Enter для продолжения...");
                Console.ReadLine();
            }
        }
    }
}