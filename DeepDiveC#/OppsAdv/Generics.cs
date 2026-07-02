using System;

// Generics in C#
// Generics allow you to define classes, methods, and data structures with a placeholder for the type of data they store or use. 
// This allows for code reusability and type safety, as you can create a single class or method that works with different data types 
// without sacrificing performance or type checking.

class Box<T>
{
    public T Value { get; set; }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    static void Main()
    {
        Box<int> number = new Box<int>();

        number.Value = 100;

        number.Display();

        Box<string> name = new Box<string>();

        name.Value = "Sumit";

        name.Display();
    }
}