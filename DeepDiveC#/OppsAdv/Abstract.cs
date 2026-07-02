// // Suppose every employee in a company has:

// // a name
// // a method to display the name

// // But salary calculation is different for each type of employee.

// // Full-time employee → Fixed monthly salary
// // Part-time employee → Hours × Rate

// // Since we don't know how every employee's salary is calculated, we make that method abstract.


// // abstract classes in C# are the classes that:
//     // - cannot be instantiated
//     // - can define some base/shared functionality.
//     // - can have abstract methods
// //Abstract class is a class that cannot be instantiated and is used as a base class for other classes. 
// // It can contain abstract methods, which are methods without implementation that must be implemented in derived classes. 
// // Abstract classes can also contain concrete methods with implementation.
// // we use override to implement the abstract method in the derived classes. since the method already exist in the base class, we use override to implement it in the derived classes.
// // also we use base keyword to call the constructor of the base class from the derived class constructor

// abstract class Employee
// {
//     String name{ get; set; }
//     public Employee(String name)
//     {
//         this.name = name;
//     }

//     public void display()
//     {
//         Console.WriteLine($"Employee Name: {name}");
//     }

//     public abstract double calculateSalary();
// }

// class FullTimeEmployee : Employee
// {
//     double salary{ get; set; }
//     public FullTimeEmployee(String name, double salary) : base(name)
//     {
//         this.salary = salary;
//     }
//     public override double calculateSalary()
//     {

//         Console.WriteLine($"Full Time Employee Salary: {salary}");
//         return salary;
//     }
// }

// class PartTimeEmployee : Employee
// {
//     public int HoursWorked { get; set; }
//     public double HourlyRate { get; set; }

//     public PartTimeEmployee(string name, int hours, double rate)
//         : base(name)
//     {
//         HoursWorked = hours;
//         HourlyRate = rate;
//     }

//     public override double calculateSalary()
//     {
//         return HoursWorked * HourlyRate;
//     }
// }

// class Abstract
// {
//     public static void Main(String[] args)
//     {
//         FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John Doe", 5000);
//         fullTimeEmployee.display();
//         fullTimeEmployee.calculateSalary();

//         PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Jane Smith", 20, 15);
//         partTimeEmployee.display();
//         double salary = partTimeEmployee.calculateSalary();
//         Console.WriteLine($"Part Time Employee Salary: {salary}");
//     }
// }