//ЗАДАЧА 1 
Console.WriteLine("Задача 1: Поменять местами десятки и единицы");
Console.Write("Введите целое число: ");

if (int.TryParse(Console.ReadLine(), out int num))
{
    int absNum = Math.Abs(num);
    int units = absNum % 10;
    int tens = (absNum / 10) % 10;
    int rest = absNum / 100;

    int result = (units * 10 + tens + rest * 100) * Math.Sign(num);
    Console.WriteLine($"Результат: {num} -> {result}\n");
}
else
{
    Console.WriteLine("Ошибка: введено некорректное число.\n");
}

//ЗАДАЧА 2 
Console.WriteLine("Задача 2: Сложение двух int с проверкой переполнения");
Console.Write("Введите первое число (int): ");
bool isNum1Valid = int.TryParse(Console.ReadLine(), out int a);

Console.Write("Введите второе число (int): ");
bool isNum2Valid = int.TryParse(Console.ReadLine(), out int b);

if (isNum1Valid && isNum2Valid)
{
    try
    {
        checked
        {
            int sum = a + b;
            Console.WriteLine($"Сумма: {a} + {b} = {sum}");
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine($"Ошибка: переполнение! {a} + {b} не помещается в тип int.");
    }
}
else
{
    Console.WriteLine("Ошибка: одно или оба значения не являются корректными числами int.");
}
Console.WriteLine();

//ЗАДАЧА 3
Console.WriteLine("Задача 3: Сезон по номеру месяца");
Console.Write("Введите номер месяца (1-12): ");

if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
{
    string season = month switch
    {
        12 or 1 or 2 => "Зима",
        3 or 4 or 5 => "Весна",
        6 or 7 or 8 => "Лето",
        9 or 10 or 11 => "Осень",
        _ => "" 
    };
    Console.WriteLine($"Месяц {month} — это {season}.\n");
}
else
{
    Console.WriteLine("Ошибка: месяц должен быть числом от 1 до 12.\n");
}

//ЗАДАЧА 4 
Console.WriteLine("Задача 4: Существует ли треугольник?");
Console.Write("Введите длину стороны a: ");
bool isSideAValid = double.TryParse(Console.ReadLine(), out double sideA);

Console.Write("Введите длину стороны b: ");
bool isSideBValid = double.TryParse(Console.ReadLine(), out double sideB);

Console.Write("Введите длину стороны c: ");
bool isSideCValid = double.TryParse(Console.ReadLine(), out double sideC);

if (isSideAValid && isSideBValid && isSideCValid)
{
    bool exists = (sideA > 0 && sideB > 0 && sideC > 0) &&
                  (sideA + sideB > sideC) &&
                  (sideA + sideC > sideB) &&
                  (sideB + sideC > sideA);

    if (exists)
        Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} СУЩЕСТВУЕТ.");
    else
        Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} НЕ существует.");
}
else
{
    Console.WriteLine("Ошибка: все стороны должны быть корректными числами.");
}