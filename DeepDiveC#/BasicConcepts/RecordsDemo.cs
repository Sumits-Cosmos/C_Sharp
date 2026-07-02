using System;
using System.Collections.Generic;

namespace RecordsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //=========================================================
            // 1. Basic Record
            //=========================================================

            Console.WriteLine("===== Basic Record =====");

            Person person = new("Sumit", 21);
            Console.WriteLine(person);

            Console.WriteLine();



            //=========================================================
            // 2. Value Equality
            //=========================================================

            Console.WriteLine("===== Value Equality =====");

            Person p1 = new("Sumit", 21);
            Person p2 = new("Sumit", 21);

            Console.WriteLine(p1 == p2);          // True
            Console.WriteLine(p1.Equals(p2));     // True

            Console.WriteLine();



            //=========================================================
            // 3. Class Equality (Comparison)
            //=========================================================

            Console.WriteLine("===== Class Equality =====");

            Student s1 = new Student("Sumit", 21);
            Student s2 = new Student("Sumit", 21);

            Console.WriteLine(s1 == s2);          // False
            Console.WriteLine(s1.Equals(s2));     // False

            Console.WriteLine();



            //=========================================================
            // 4. With Expression
            //=========================================================

            Console.WriteLine("===== With Expression =====");

            Person original = new("Sumit", 21);

            Person modified = original with
            {
                Age = 22
            };

            Console.WriteLine(original);
            Console.WriteLine(modified);

            Console.WriteLine();



            //=========================================================
            // 5. Immutability
            //=========================================================

            Console.WriteLine("===== Immutability =====");

            Person immutable = new("Rahul", 25);

            // immutable.Age = 30;
            // Uncommenting the above line gives compile-time error

            Console.WriteLine(immutable);

            Console.WriteLine();



            //=========================================================
            // 6. Record with Custom Method
            //=========================================================

            Console.WriteLine("===== Record Method =====");

            Employee emp = new("Alice", 50000);

            Console.WriteLine(emp.YearlySalary());

            Console.WriteLine();



            //=========================================================
            // 7. Record with Additional Properties
            //=========================================================

            Console.WriteLine("===== Additional Properties =====");

            Product product = new(101, "Laptop")
            {
                Price = 65000
            };

            Console.WriteLine(product);

            Console.WriteLine();



            //=========================================================
            // 8. Record Struct
            //=========================================================

            Console.WriteLine("===== Record Struct =====");

            Point point = new(10, 20);

            Console.WriteLine(point);

            Console.WriteLine();



            //=========================================================
            // 9. Positional Record
            //=========================================================

            Console.WriteLine("===== Positional Record =====");

            Book book = new("Atomic Habits", "James Clear");

            Console.WriteLine(book);

            Console.WriteLine();



            //=========================================================
            // 10. Property Record
            //=========================================================

            Console.WriteLine("===== Property Record =====");

            Car car = new()
            {
                Brand = "BMW",
                Model = "M5"
            };

            Console.WriteLine(car);

            Console.WriteLine();



            //=========================================================
            // 11. Deconstruction
            //=========================================================

            Console.WriteLine("===== Deconstruction =====");

            Person user = new("Rohit", 24);

            var (name, age) = user;

            Console.WriteLine(name);
            Console.WriteLine(age);

            Console.WriteLine();



            //=========================================================
            // 12. Record Inheritance
            //=========================================================

            Console.WriteLine("===== Record Inheritance =====");

            Dog dog = new("Tommy", "Golden Retriever");

            Console.WriteLine(dog);

            Console.WriteLine();



            //=========================================================
            // 13. HashSet Example
            //=========================================================

            Console.WriteLine("===== HashSet =====");

            HashSet<Person> people = new();

            people.Add(new Person("Sumit", 21));
            people.Add(new Person("Sumit", 21));

            Console.WriteLine(people.Count);

            Console.WriteLine();



            //=========================================================
            // 14. Dictionary Key Example
            //=========================================================

            Console.WriteLine("===== Dictionary =====");

            Dictionary<Person, string> dictionary = new();

            dictionary[new Person("Raj", 20)] = "Developer";

            Console.WriteLine(dictionary[new Person("Raj", 20)]);

            Console.WriteLine();



            //=========================================================
            // 15. Equality with Different Values
            //=========================================================

            Console.WriteLine("===== Different Values =====");

            Person person1 = new("A", 10);
            Person person2 = new("A", 11);

            Console.WriteLine(person1 == person2);

            Console.WriteLine();



            //=========================================================
            // 16. Nested Records
            //=========================================================

            Console.WriteLine("===== Nested Record =====");

            Address address = new("Bangalore", "Karnataka");

            Customer customer = new("Sumit", address);

            Console.WriteLine(customer);

            Console.WriteLine();



            //=========================================================
            // 17. ToString()
            //=========================================================

            Console.WriteLine("===== Auto ToString =====");

            Console.WriteLine(customer);

            Console.WriteLine();



            //=========================================================
            // 18. Copy Entire Object
            //=========================================================

            Console.WriteLine("===== Copy Record =====");

            Person copy = person with { };

            Console.WriteLine(copy);

            Console.WriteLine();



            //=========================================================
            // END
            //=========================================================
        }
    }



    //=========================================================
    // Basic Record
    //=========================================================

    public record Person(string Name, int Age);



    //=========================================================
    // Normal Class
    //=========================================================

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }



    //=========================================================
    // Record with Method
    //=========================================================

    public record Employee(string Name, decimal Salary)
    {
        public decimal YearlySalary()
        {
            return Salary * 12;
        }
    }



    //=========================================================
    // Record with Extra Property
    //=========================================================

    public record Product(int Id, string Name)
    {
        public decimal Price { get; init; }
    }



    //=========================================================
    // Record Struct
    //=========================================================

    public readonly record struct Point(int X, int Y);



    //=========================================================
    // Positional Record
    //=========================================================

    public record Book(string Title, string Author);



    //=========================================================
    // Property Record
    //=========================================================

    public record Car
    {
        public string Brand { get; init; }
        public string Model { get; init; }
    }



    //=========================================================
    // Record Inheritance
    //=========================================================

    public record Animal(string Name);

    public record Dog(string Name, string Breed)
        : Animal(Name);



    //=========================================================
    // Nested Records
    //=========================================================

    public record Address(string City, string State);

    public record Customer(string Name, Address Address);
}