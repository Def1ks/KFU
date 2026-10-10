using System;

class Rectangle
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public void Print()
    {
        Console.WriteLine($"Прямоугольник: ширина={Width}, высота={Height}, площадь={GetArea()}");
    }
}