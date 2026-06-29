// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Let's start coding in C#");

//  Variables in C# 

//Strings

// String name = "John Doe";

// Console.WriteLine(name);

// String firstName;
// firstName = Console.ReadLine();

// String lastName = "Smith";

// String fullName = firstName + " " + lastName;

// Console.WriteLine(fullName);

// Char grade = 'A';
// Console.WriteLine(grade);


//Intergers 

// int age =  30;
// Console.WriteLine(age);
// int year = 2024;

// Console.WriteLine("year after 30 year will be :" + (year + age));
// Console.WriteLine($"year after 30 year will be :  {year + age}");

// similar division, multiplication, addition, subtraction, and modulus operators are available in C# as well.

//Float, Double

// float price = 10.99f;   // for float we need to add f at the end of the number ---> provides 32bit precision
// double balance = 1000.50; // for double we don't need to add anything at the end of the number ---> provides 64bit precision

// Console.WriteLine(price);
// Console.WriteLine(balance);

// similar division, multiplication, addition, subtraction, and modulus operators are available in C# as well.

// Boolean 

// bool isCSharpFun = true;
// bool isFishTasty = false;

// Console.WriteLine(isCSharpFun);
// Console.WriteLine(isFishTasty);

// // Boolean Operators - AND (&&), OR (||), NOT (!)

// // AND (&&) - both must be true
// Console.WriteLine("\n--- AND (&&) Operator ---");
// Console.WriteLine(true && true);     // true
// Console.WriteLine(true && false);    // false
// Console.WriteLine(false && true);    // false
// Console.WriteLine(false && false);   // false

// // OR (||) - at least one must be true
// Console.WriteLine("\n--- OR (||) Operator ---");
// Console.WriteLine(true || true);     // true
// Console.WriteLine(true || false);    // true
// Console.WriteLine(false || true);    // true
// Console.WriteLine(false || false);   // false

// // NOT (!) - negates the value
// Console.WriteLine("\n--- NOT (!) Operator ---");
// Console.WriteLine(!true);            // false
// Console.WriteLine(!false);           // true

// // Combinations with variables
// Console.WriteLine("\n--- Using Variables ---");
// Console.WriteLine(isCSharpFun && isFishTasty);   // false
// Console.WriteLine(isCSharpFun || isFishTasty);   // true
// Console.WriteLine(!isCSharpFun);                 // false
// Console.WriteLine(!isFishTasty);                 // true


// DateTime

// DateTime currentDate =  DateTime.Now;
// Console.WriteLine("Current Date and Time: " + currentDate);
// DateOnly dateOnly =  DateOnly.FromDateTime(currentDate);
// TimeOnly timeOnly = TimeOnly.FromDateTime(currentDate);
// Console.WriteLine("Date Only: " + dateOnly + " Time Only: " + timeOnly);


// Arrays, List, Dictionaries, HashSet, Queue, Stack

// Array: fixed-size collection of same type items.
// int[] numbers = { 1, 2, 3, 4 };
// Console.WriteLine(numbers[0]); // 1

// List<T>: dynamic-size collection, can grow or shrink.
// List<string> names = new List<string> { "Alice", "Bob" };
// names.Add("Charlie");
// Console.WriteLine(names.Count); // 3

// Dictionary<TKey,TValue>: stores key-value pairs for fast lookup.
// Dictionary<string, int> ages = new Dictionary<string, int>
// {
//     { "Alice", 30 },
//     { "Bob", 25 }
// };
// Console.WriteLine(ages["Bob"]); // 25

// HashSet<T>: collection of unique items, no duplicates allowed.
// HashSet<int> ids = new HashSet<int> { 1, 2, 3 };
// ids.Add(2); // ignored because 2 already exists
// Console.WriteLine(ids.Count); // 3

// Queue<T>: first-in, first-out (FIFO) collection.
// Queue<string> queue = new Queue<string>();
// queue.Enqueue("first");
// queue.Enqueue("second");
// Console.WriteLine(queue.Dequeue()); // first

// Stack<T>: last-in, first-out (LIFO) collection.
// Stack<string> stack = new Stack<string>();
// stack.Push("bottom");
// stack.Push("top");
// Console.WriteLine(stack.Pop()); // top


