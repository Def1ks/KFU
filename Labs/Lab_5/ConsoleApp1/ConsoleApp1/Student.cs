using System;

class Student
{
    public string Name;
    public int Age;

    public void Print()
    {
        Console.WriteLine($"Студент: {Name}, Возраст: {Age}");
    }
}