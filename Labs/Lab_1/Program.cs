// Главное меню
Console.WriteLine("Меню");
Console.WriteLine("1 - День недели");
Console.WriteLine("2 - Проверка года");
Console.WriteLine("3 - Калькулятор");
Console.WriteLine("4 - Квадратное уравнение");
Console.Write("Выберите пункт (1-4): ");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Ошибка: нужно ввести число.");
        return;
    }

    switch (choice)
    {
        case 1: TaskDayOfWeek(); break;
        case 2: TaskLeapYear(); break;
        case 3: TaskCalculator(); break;
        case 4: TaskQuadraticEquation(); break;
        default: Console.WriteLine("Такого пункта меню нет."); break;
    }

    //ЗАДАНИЕ 1
static void TaskDayOfWeek()
{
    Console.Write("\nВведите число от 1 до 7: ");
    if (!int.TryParse(Console.ReadLine(), out int dayNum))
    {
        Console.WriteLine("Ошибка ввода.");
        return;
    }

    string dayName;
    switch (dayNum)
    {
        case 1: dayName = "Понедельник"; break;
        case 2: dayName = "Вторник"; break;
        case 3: dayName = "Среда"; break;
        case 4: dayName = "Четверг"; break;
        case 5: dayName = "Пятница"; break;
        case 6: dayName = "Суббота"; break;
        case 7: dayName = "Воскресенье"; break;
        default: dayName = "Некорректное число"; break;
    }
    Console.WriteLine(dayName);
}

//ЗАДАНИЕ 2
static void TaskLeapYear()
{
    Console.Write("\nВведите год: ");
    if (!int.TryParse(Console.ReadLine(), out int yearVal))
    {
        Console.WriteLine("Ошибка ввода.");
        return;
    }

    if ((yearVal % 400 == 0) || ((yearVal % 4 == 0) && (yearVal % 100 != 0)))
    {
        Console.WriteLine("Год високосный");
    }
    else
    {
        Console.WriteLine("Год не високосный");
    }
}

//ЗАДАНИЕ 3
static void TaskCalculator()
{
    Console.Write("\nПервое число: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Ошибка ввода первого числа.");
        return;
    }

    Console.Write("Второе число: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Ошибка ввода второго числа.");
        return;
    }

    Console.WriteLine("Меню:\n1 - Сложить\n2 - Вычесть\n3 - Умножить\n4 - Разделить");
    Console.Write("Действие (1-4): ");
        
    if (!int.TryParse(Console.ReadLine(), out int action))
    {
        Console.WriteLine("Ошибка выбора действия.");
        return;
    }

    double result = 0;
    bool success = true;

    switch (action)
    {
        case 1: result = num1 + num2; break;
        case 2: result = num1 - num2; break;
        case 3: result = num1 * num2; break;
        case 4:
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                success = false;
            }
            break;
        default:
            Console.WriteLine("Неизвестная операция.");
            success = false;
            break;
    }

    if (success)
        Console.WriteLine($"Результат: {result}");
}

//ЗАДАНИЕ 4
static void TaskQuadraticEquation()
{
    Console.Write("\nВведите a: ");
    if (!double.TryParse(Console.ReadLine(), out double coefA))
    {
        Console.WriteLine("Ошибка ввода a.");
        return;
    }

    Console.Write("Введите b: ");
    if (!double.TryParse(Console.ReadLine(), out double coefB))
    {
        Console.WriteLine("Ошибка ввода b.");
        return;
    }

    Console.Write("Введите c: ");
    if (!double.TryParse(Console.ReadLine(), out double coefC))
    {
        Console.WriteLine("Ошибка ввода c.");
        return;
    }

    if (coefA == 0)
    {
        Console.WriteLine("Ошибка: 'a' не может быть равно 0.");
        return;
    }

    double discriminant = coefB * coefB - 4 * coefA * coefC;
    Console.WriteLine($"Дискриминант D = {discriminant}");

    if (discriminant > 0)
    {
        double x1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
        double x2 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
        Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
    }
    else if (discriminant == 0)
    {
    double x = -coefB / (2 * coefA);
        Console.WriteLine($"Один корень: x = {x}");
    }
    else
    {
        Console.WriteLine("Действительных корней нет.");
    }
}