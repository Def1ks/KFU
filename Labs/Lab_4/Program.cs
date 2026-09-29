Console.WriteLine("Выберите задание (1-5) или 0 для выхода:");
Console.WriteLine("1. SayHello");
Console.WriteLine("2. Square");
Console.WriteLine("3. Average");
Console.WriteLine("4. Calculate");
Console.WriteLine("5. MinMax");
Console.Write("Ваш выбор: ");

if (!int.TryParse(Console.ReadLine(), out int choice))
{
    Console.WriteLine("Ошибка ввода выбора!");
    return;
}

switch (choice)
{
    case 1:
        SayHello();
        SayHello();
        SayHello();
        break;

    case 2:
        Console.Write("Введите число x: ");
        if (int.TryParse(Console.ReadLine(), out int x))
            Console.WriteLine($"Квадрат числа {x} = {Square(x)}");
        else
            Console.WriteLine("Ошибка: введено не целое число.");
        break;

    case 3:
        Console.Write("Введите количество чисел: ");
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            double[] nums = new double[count];
            bool validInput = true;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Число {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out nums[i]))
                {
                    Console.WriteLine("Ошибка: введено не число.");
                    validInput = false;
                    break;
                }
            }

            if (validInput)
                Console.WriteLine($"Среднее арифметическое = {Average(nums)}");
        }
        else
        {
            Console.WriteLine("Ошибка: количество должно быть положительным числом.");
        }
        break;

    case 4:
        Console.Write("Введите первое число: ");
        if (double.TryParse(Console.ReadLine(), out double a))
        {
            Console.Write("Введите второе число: ");
            if (double.TryParse(Console.ReadLine(), out double b))
            {
                Console.Write("Введите оператор (+, -, *, /): ");
                string? opStr = Console.ReadLine();

                if (!string.IsNullOrEmpty(opStr) && char.TryParse(opStr, out char op))
                {
                    try
                    {
                        Console.WriteLine($"Результат = {Calculate(a, b, op)}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: оператор должен быть одним символом.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: второе значение не является числом.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: первое значение не является числом.");
        }
        break;

    case 5:
        Console.Write("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        {
            int[] arr = new int[size];
            bool validInput = true;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Ошибка: введено не целое число.");
                    validInput = false;
                    break;
                }
            }

            if (validInput)
            {
                MinMax(arr, out int min, out int max);
                Console.WriteLine($"Min = {min}, Max = {max}");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: размер массива должен быть положительным числом.");
        }
        break;

    default:
        Console.WriteLine("Неверный выбор!");
        break;
}

static void SayHello()
{
    Console.WriteLine("Привет, студент!");
}

static int Square(int x)
{
    return x * x;
}

static double Average(params double[] numbers)
{
    if (numbers.Length == 0)
        throw new ArgumentException("Массив не должен быть пустым");

    double sum = 0;
    foreach (double num in numbers)
        sum += num;

    return sum / numbers.Length;
}

static double Calculate(double a, double b, char op)
{
    switch (op)
    {
        case '+': return a + b;
        case '-': return a - b;
        case '*': return a * b;
        case '/':
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно!");
            return a / b;
        default:
            throw new ArgumentException($"Неизвестный оператор: '{op}'");
    }
}

static void MinMax(int[] arr, out int min, out int max)
{
    if (arr == null || arr.Length == 0)
        throw new ArgumentException("Массив не должен быть пустым");

    min = arr[0];
    max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
}