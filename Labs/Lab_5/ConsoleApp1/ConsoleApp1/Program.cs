using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var dev = new Student();
            dev.Name = "Dinar";
            dev.Age = 22;
            dev.Print();

            var admin = new Person("Root", 99);
            admin.Print();

            var doc1 = new Book();              
            var doc2 = new Book("API_Design");  
            doc1.Print();
            doc2.Print();

            var user1 = new Person("Alex", 25);
            var user2 = user1;
            user2.Name = "Admin_Alex";

            Console.WriteLine($"user1: {user1.Name}"); 
            Console.WriteLine($"user2: {user2.Name}");

            var pt1 = new Point(0, 0);
            var pt2 = pt1;
            pt2.X = 100;

            Console.WriteLine($"pt1: ({pt1.X}, {pt1.Y})"); 
            Console.WriteLine($"pt2: ({pt2.X}, {pt2.Y})"); 

            var screen = new Rectangle(1920, 1080);
            Console.WriteLine($"Разрешение: {screen.Width}x{screen.Height}");
            Console.WriteLine($"Площадь пикселей: {screen.GetArea()}");

            var wallet = new BankAccount("Main_Salary", 50000);
            wallet.Deposit(15000);   
            wallet.Withdraw(20000);  
            wallet.Withdraw(999999); 
            wallet.Print();          

            Console.ReadKey();
        }
    }
}