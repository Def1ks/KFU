
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

Console.Write("Введите год: ");
int year = int.Parse(Console.ReadLine());

if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}