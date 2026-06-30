// using System;

// // OOPs in C# example showing Encapsulation, Inheritance, Polymorphism, and Abstraction

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("OOPs concepts in C#:\n");

//         // Encapsulation example
//         Person person = new Person();
//         person.Name = "Amit";
//         person.Age = 25;
//         Console.WriteLine($"Encapsulation -> Name: {person.Name}, Age: {person.Age}");

//         // Inheritance and Polymorphism example
//         Animal dog = new Dog("Sheru");
//         Animal cat = new Cat("Mimi");
//         dog.Speak();
//         cat.Speak();

//         // Abstraction example
//         Shape circle = new Circle(5);
//         Console.WriteLine($"Abstraction -> Circle area: {circle.GetArea():F2}");
//     }
// }

// // Encapsulation: data is wrapped in a class, and access is controlled by properties.
// class Person
// {
//     public string Name { get; set; }

//     private int age;
//     public int Age
//     {
//         get => age;
//         set
      
//     public override double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }
//   {
//             if (value >= 0)
//                 age = value;
//         }
//     }
// }

// // Inheritance and Polymorphism: base class Animal and derived classes Dog and Cat.
// class Animal
// {
//     protected string Name;

//     public Animal(string name)
//     {
//         Name = name;
//     }

//     public virtual void Speak()
//     {
//         Console.WriteLine($"{Name} makes a sound.");
//     }
// }

// class Dog : Animal
// {
//     public Dog(string name) : base(name) { }

//     public override void Speak()
//     {
//         Console.WriteLine($"{Name} says: Woof!");
//     }
// }

// class Cat : Animal
// {
//     public Cat(string name) : base(name) { }

//     public override void Speak()
//     {
//         Console.WriteLine($"{Name} says: Meow!");
//     }
// }

// // Abstraction: abstract class Shape hides implementation details.
//     public override double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }

// abstract class Shape
// {
//     public abstract double GetArea();
// }

// class Circle : Shape
// {
//     public double Radius { get; }

//     public Circle(double radius)
//     {
//         Radius = radius;
//     }

//     public override double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }




// Reference types in c#

