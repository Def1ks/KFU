Console.WriteLine("Меню задач:");
Console.WriteLine("1. Поиск индекса в отсортированном массиве");
Console.WriteLine("2. НОД (Алгоритм Евклида)");
Console.WriteLine("3. Проверка на совершенное число");
Console.WriteLine("4. Таблица умножения");
Console.Write("Выберите задачу (1-4): ");

string menuInput = Console.ReadLine();
int.TryParse(menuInput, out int choice);

switch (choice)
{
    case 1:
        int[] arr = { 1, 3, 5, 6 };
        
        Console.WriteLine("Массив: 1, 3, 5, 6");
        Console.Write("Введите целевое число: ");
        string targetInput = Console.ReadLine();
        int.TryParse(targetInput, out int target);

        int index = -1;
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                index = i;
                found = true;
                break; 
            }
            if (arr[i] > target)
            {
                index = i;
                break;
            }
        }

        if (!found && index == -1) 
        {
            index = arr.Length;
        }

        Console.WriteLine("Индекс: " + index);
        break;

    case 2:
        Console.Write("Введите первое число (a): ");
        string aInput = Console.ReadLine();
        int.TryParse(aInput, out int a);

        Console.Write("Введите второе число (b): ");
        string bInput = Console.ReadLine();
        int.TryParse(bInput, out int b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine("НОД равен: " + a);
        break;

    case 3:
        Console.Write("Введите число для проверки: ");
        string numInput = Console.ReadLine();
        int.TryParse(numInput, out int number);

        int sumDivisors = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumDivisors = sumDivisors + i;
            }
        }

        if (sumDivisors == number)
        {
            Console.WriteLine("Число " + number + " является совершенным.");
        }
        else
        {
            Console.WriteLine("Число " + number + " НЕ является совершенным.");
        }
        break;

    case 4:
        Console.Write("Для какого числа вывести таблицу? ");
        string tableInput = Console.ReadLine();
        int.TryParse(tableInput, out int n);

        Console.WriteLine("Таблица умножения для " + n + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " * " + i + " = " + (n * i));
        }
        break;

    default:
        Console.WriteLine("Неверный номер задачи.");
        break;
}