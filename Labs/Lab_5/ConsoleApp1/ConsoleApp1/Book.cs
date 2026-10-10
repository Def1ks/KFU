using System;

class Book
{
    public string Title;

    public Book()
    {
        Title = "Без названия";
    }

    public Book(string title)
    {
        this.Title = title;
    }

    public void Print()
    {
        Console.WriteLine($"Книга: \"{Title}\"");
    }
}