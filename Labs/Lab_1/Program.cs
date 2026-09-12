
// Console.Write("Введите число от 1 до 7: ");
// int d = int.Parse(Console.ReadLine());

// string N;

// switch (d)
// {
//     case 1: N = "Понедельник"; break;
//     case 2: N = "Вторник"; break;
//     case 3: N = "Среда"; break;
//     case 4: N = "Четверг"; break;
//     case 5: N = "Пятница"; break;
//     case 6: N = "Суббота"; break;
//     case 7: N = "Воскресенье"; break;
//     default: N = "Некорректное число"; break;
// }

// Console.WriteLine(N);

// Console.Write("Введите год: ");
// int year = int.Parse(Console.ReadLine());

// if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
// {
//     Console.WriteLine("Год високосный");
// }
// else
// {
//     Console.WriteLine("Год не високосный");
// }

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("Меню: \n1 - Сложить \n2 - Вычесть \n3 - Умножить \n4 - Разделить\n");
// int num = int.Parse(Console.ReadLine());

// int sum = 0;

// switch (num)
// {
//     case 1: Console.WriteLine(sum = a + b); break;
//     case 2: Console.WriteLine(sum = a - b); break;
//     case 3: Console.WriteLine(sum = a * b); break;
//     case 4: 
//     if (b != 0) 
//         {
//         Console.WriteLine(sum = a / b);
//         }
//         else
//         {
//             Console.WriteLine("Деление на ноль");
//         }
//         ; break;
//     default: Console.WriteLine("Ошибка"); break;
// }

Console.Write("Введите коэффициент a: ");
    if (!double.TryParse(Console.ReadLine(), out double a))
    {
        Console.WriteLine("Ошибка ввода a.");
        return;
    }

Console.Write("Введите коэффициент b: ");
    if (!double.TryParse(Console.ReadLine(), out double b))
    {
        Console.WriteLine("Ошибка ввода b.");
        return;
    }

Console.Write("Введите коэффициент c: ");
    if (!double.TryParse(Console.ReadLine(), out double c))
    {
        Console.WriteLine("Ошибка ввода c.");
        return;
    }

    if (a == 0)
    {
        Console.WriteLine("Коэффициент 'a' не может быть равен 0 (это не квадратное уравнение).");
        return;
    }

double D = b * b - 4 * a * c;
Console.WriteLine($"Дискриминант D = {D}");

    if (D > 0)
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"Уравнение имеет два корня:");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
    }
    else if (D == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"Уравнение имеет один корень:");
        Console.WriteLine($"x = {x}");
    }
    else 
    {
        Console.WriteLine("Действительных корней нет (D < 0).");
    }
