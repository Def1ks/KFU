using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Человек: {Name}, Возраст: {Age}");
    }
}