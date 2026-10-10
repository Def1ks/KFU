using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            // Задача 1
            Console.WriteLine("ЗАДАЧА 1: Student");
            Student student = new Student();
            student.Name = "Иван";
            student.Age = 20;
            student.Print();
            Console.WriteLine();

            // Задача 2
            Console.WriteLine("ЗАДАЧА 2: Person");
            Person person = new Person("Мария", 25);
            person.Print();
            Console.WriteLine();

            // Задача 3
            Console.WriteLine("ЗАДАЧА 3: Book");
            Book book1 = new Book();
            Book book2 = new Book("C# для начинающих");
            book1.Print();
            book2.Print();
            Console.WriteLine();

            // Задача 4
            Console.WriteLine("ЗАДАЧА 4: Ссылки на объект");
            Person p1 = new Person("Алексей", 30);
            Person p2 = p1;
            Console.WriteLine("До изменения:");
            p1.Print();
            p2.Print();

            p2.Name = "Дмитрий";
            Console.WriteLine("После изменения через p2:");
            p1.Print();
            p2.Print();
            Console.WriteLine();

            // Задача 5
            Console.WriteLine("ЗАДАЧА 5: Struct Point");
            Point point1 = new Point(10, 20);
            Point point2 = point1;

            Console.Write("Оригинал: "); point1.Print();
            Console.Write("Копия до изменения: "); point2.Print();

            point2.X = 99;
            point2.Y = 88;

            Console.Write("Копия после изменения: "); point2.Print();
            Console.Write("Оригинал (не изменился): "); point1.Print();
            Console.WriteLine();

            // Задача 6
            Console.WriteLine("ЗАДАЧА 6: Rectangle");
            Rectangle rect = new Rectangle(5.5, 3.2);
            rect.Print();
            Console.WriteLine($"Площадь через GetArea(): {rect.GetArea()}");
            Console.WriteLine();

            // Задача 7
            Console.WriteLine(" ЗАДАЧА 7: BankAccount");
            BankAccount account = new BankAccount("Иван Петров", 1000);
            account.Print();
            account.Deposit(500);
            account.Withdraw(300);
            account.Withdraw(5000);
            account.Print();
            Console.WriteLine();

            Console.WriteLine("Все задачи выполнены!");
            Console.ReadKey();
        }
    }
}