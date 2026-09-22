Console.WriteLine("1 - День недели");
Console.WriteLine("2 - Проверка года");
Console.WriteLine("3 - Калькулятор");
Console.WriteLine("4 - Квадратное уравнение");
Console.Write("Выбери пункт (1-4): ");

string input = Console.ReadLine();
int.TryParse(input, out int choice);

if (choice == 1)
{
    Console.Write("Введи число от 1 до 7: ");
    string dayInput = Console.ReadLine();
    int.TryParse(dayInput, out int day);

    if (day == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (day == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (day == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (day == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (day == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (day == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (day == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    else
    {
        Console.WriteLine("Неправильное число");
    }
}
else if (choice == 2)
{
    Console.Write("Введи год: ");
    string yearInput = Console.ReadLine();
    int.TryParse(yearInput, out int year);

    if (year % 400 == 0)
    {
        Console.WriteLine("Високосный");
    }
    else if (year % 4 == 0 && year % 100 != 0)
    {
        Console.WriteLine("Високосный");
    }
    else
    {
        Console.WriteLine("Невисокосный");
    }
}
else if (choice == 3)
{
    Console.Write("Первое число: ");
    string num1Input = Console.ReadLine();
    double.TryParse(num1Input, out double num1);

    Console.Write("Второе число: ");
    string num2Input = Console.ReadLine();
    double.TryParse(num2Input, out double num2);

    Console.Write("Операция (+, -, *, /): ");
    string opInput = Console.ReadLine();
    char.TryParse(opInput, out char op);

    if (op == '+')
    {
        double result = num1 + num2;
        Console.WriteLine("Ответ: " + result);
    }
    else if (op == '-')
    {
        double result = num1 - num2;
        Console.WriteLine("Ответ: " + result);
    }
    else if (op == '*')
    {
        double result = num1 * num2;
        Console.WriteLine("Ответ: " + result);
    }
    else if (op == '/')
    {
        if (num2 == 0)
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine("Ответ: " + result);
        }
    }
    else
    {
        Console.WriteLine("Неизвестная операция");
    }
}
else if (choice == 4)
{
    Console.Write("Введи a: ");
    string aInput = Console.ReadLine();
    double.TryParse(aInput, out double a);

    if (a == 0)
    {
        Console.WriteLine("a не может быть 0");
    }
    else
    {
        Console.Write("Введи b: ");
        string bInput = Console.ReadLine();
        double.TryParse(bInput, out double b);

        Console.Write("Введи c: ");
        string cInput = Console.ReadLine();
        double.TryParse(cInput, out double c);

        double D = b * b - 4 * a * c;

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x = " + x);
        }
        else
        {
            Console.WriteLine("Корней нет");
        }
    }
}
else
{
    Console.WriteLine("Неправильный пункт");
}