ShowMenu();
    
string menuInput = Console.ReadLine();
int.TryParse(menuInput, out int choice);

    switch (choice)
    {
        case 1:
            TaskSearchIndex();
            break;
        case 2:
            TaskGCD();
            break;
        case 3:
            TaskPerfectNumber();
            break;
        case 4:
            TaskMultiplicationTable();
            break;
        default:
            Console.WriteLine("Неверный номер задачи.");
            break;
    }

void ShowMenu()
{
    Console.WriteLine("Меню задач:");
    Console.WriteLine("1. Поиск индекса в отсортированном массиве");
    Console.WriteLine("2. НОД (Алгоритм Евклида)");
    Console.WriteLine("3. Проверка на совершенное число");
    Console.WriteLine("4. Таблица умножения");
    Console.Write("Выберите задачу (1-4): ");
}

void TaskSearchIndex()
{
    int[] arr = { 1, 3, 5, 6 };
    
    Console.WriteLine("Массив: 1, 3, 5, 6");
    Console.Write("Введите целевое число: ");
    string targetInput = Console.ReadLine();
    int.TryParse(targetInput, out int target);

    int index = FindInsertIndex(arr, target);
    Console.WriteLine("Индекс: " + index);
}

int FindInsertIndex(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i;
        }
        if (arr[i] > target)
        {
            return i;
        }
    }
    return arr.Length;
}

void TaskGCD()
{
    Console.Write("Введите первое число (a): ");
    string aInput = Console.ReadLine();
    int.TryParse(aInput, out int a);

    Console.Write("Введите второе число (b): ");
    string bInput = Console.ReadLine();
    int.TryParse(bInput, out int b);

    int gcd = CalculateGCD(a, b);
    Console.WriteLine("НОД равен: " + gcd);
}

int CalculateGCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

void TaskPerfectNumber()
{
    Console.Write("Введите число для проверки: ");
    string numInput = Console.ReadLine();
    int.TryParse(numInput, out int number);

    bool isPerfect = IsPerfectNumber(number);
    
    if (isPerfect)
    {
        Console.WriteLine("Число " + number + " является совершенным.");
    }
    else
    {
        Console.WriteLine("Число " + number + " НЕ является совершенным.");
    }
}

bool IsPerfectNumber(int number)
{
    int sumDivisors = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sumDivisors += i;
        }
    }
    return sumDivisors == number;
}

void TaskMultiplicationTable()
{
    Console.Write("Для какого числа вывести таблицу? ");
    string tableInput = Console.ReadLine();
    int.TryParse(tableInput, out int n);

    PrintMultiplicationTable(n);
}

void PrintMultiplicationTable(int n)
{
    Console.WriteLine("Таблица умножения для " + n + ":");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(n + " * " + i + " = " + (n * i));
    }
}
