// See https://aka.ms/new-console-template for more information
using project1;
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome");


//variable declaration
int num = 10;
string greeting = "Hello, C#";
Console.WriteLine($"Number: {num} and Greeting: {greeting}");
Console.WriteLine("Number:{0} and Greeting:{1}", num, greeting);//previous type of variable incorporation


//methods
//variabledeclarationdemo();
//info();

//Console.WriteLine(variabledeclarationdemo1());

//sampleproblem sampleproblem = new sampleproblem();
//sampleproblem.sample();
//Product product = new Product();

/*product.ProductName = "Laptop";
product.ProductPrice = 1500.00;
product.ProductQuantity = 2;
product.DisplayProductDetails();
Console.WriteLine($"Total Price: {product.CalculateTotalPrice()}");
Console.WriteLine($"Discounted Price (10% off): {product.CalculateDiscountedPrice(10)}");
Console.WriteLine($"Restock the product:{product.restock}");
Console.WriteLine($"Press any key to exit...");
*/
employeemulti employee = new employeemulti();
Console.WriteLine("Enter Employee ID:");
employee.employeemultiID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Employee Name:");
employee.Name = Console.ReadLine();
Console.WriteLine("Enter Employee City:");
employee.City = Console.ReadLine();
Console.WriteLine("Enter Employee Age:");
employee.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Employee Role:");
employee.role = Console.ReadLine();
Console.WriteLine("Enter Employee Email:");
employee.email = Console.ReadLine();
Console.WriteLine("Enter Employee Salary:");
employee.salary = Convert.ToDouble(Console.ReadLine());
employee.DisplayDetails();
Console.WriteLine($"Employee Details: Id: {employee.Id}, Name: {employee.Name}, City: {employee.City}, Age: {employee.Age}, Employee ID: {employee.employeemultiID}, Role: {employee.role}, Email: {employee.email}, Salary: {employee.salary}");
Console.WriteLine("Person Details:{}");




//multilevel inheritance
multilevel multilevel = new multilevel();
multilevel.bone(); // This will call the method from the base class and display

Person person = new Person(1, "John Doe", "New York", 30);
person.DisplayDetails();
Console.WriteLine($"Person Details:{person.GetDetails()}");
person.UpdateDetails(2, "Jane Smith", "Los Angeles", 25);
person.DisplayDetails();
Console.WriteLine($"Updated Person Details: {person.GetDetails()}");

Person person1 = new Person();
person1.Id = 3;
person1.Name = "Alice Johnson";
person1.City = "Chicago";
person1.Age = 28;
Console.WriteLine($"Person1 Details: Id: {person1.Id}, Name: {person1.Name}, City: {person1.City}, Age: {person1.Age}");
Console.WriteLine(person.ToString());

static string variabledeclarationdemo1()
{
    calc calc = new calc();
    Console.WriteLine("Enter 1st num");
    int firstnum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 2nd num");
    int secondnum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choose an operation: +,_,*,/");
    string operation = Console.ReadLine();
    int result = 0;
    switch (operation)
    {
        case "+":
            result = calc.Add(firstnum, secondnum);
            break;
        case "-":
            result = calc.Sub(firstnum, secondnum);
            break;
        case "*":
            result = calc.Multiply(firstnum, secondnum);
            break;
        case "/":
            try
            {
                result = calc.Divide(firstnum, secondnum);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return "";//Exit the program if division by zero occurs
            }
            break;
        default:
            Console.WriteLine("Invalid operation");
            return "";//Exit the program if an invalid operation is entered

    }
    string endresult = ($"The result of {firstnum}{operation}{secondnum} is: {result}");
    return endresult;
}
//int num1 = Convert.ToInt32(Console.ReadLine());
static void variabledeclarationdemo()
{
    int num = 10;
    string greeting = "Hello, C#";
    Console.WriteLine($"Number: {num} and Greeting: {greeting}");
    Console.WriteLine("Number:{0} and Greeting:{1}", num, greeting);
}
static void info()
{
    //converting

    Console.WriteLine("Name:");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}!");

    Console.WriteLine("City");
    string city = Console.ReadLine();
    Console.WriteLine($"Hello,{name} from {city}!");

    Console.WriteLine("Age");
    //int age= Console.WriteLine() !=null? int.Parse(Console.ReadLine()):0;
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello, {name} from {city}, you are {age} years old!");
}

//forloop();

static void forloop()
{
    Console.WriteLine("Enter a number:");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = n - 1; i >= 1; i--)
    {
        Console.WriteLine($"Number: {i}");
    }
}
//whileloop();

static void whileloop()
{
    Console.WriteLine("Enter a number:");
    int n = Convert.ToInt32(Console.ReadLine());
    while (n > 10)
    {
        Console.WriteLine($"Number: {n}");
        n--;
    }
}
//doWhileLoop();
static void doWhileLoop()
{
    Console.WriteLine("Enter a number:");
    int n = Convert.ToInt32(Console.ReadLine());
    do
    {
        Console.WriteLine($"Number: {n}");
        n--;
    } while (n > 10);
}



//arrays
twodimensional();

static void twodimensional()
{
    int[,] twodimensionalarray = new int[3, 3]
    {
     { 1,2,3},
    {4,5,6},
    { 7,8,9}
    };
    for (int i = 0; i < twodimensionalarray.GetLength(0); i++)
    {
        for (int j = 0; j < twodimensionalarray.GetLength(1); j++)
        {
            Console.Write(twodimensionalarray[i, j] + " ");
        }
        Console.WriteLine();
    }
}



//value type data ranges
dataranges();

static void dataranges()
{
    Console.WriteLine(int.MinValue + " " + int.MaxValue);
    Console.WriteLine(short.MinValue + " " + short.MaxValue);
    Console.WriteLine(long.MinValue + " " + long.MaxValue);
    Console.WriteLine(byte.MinValue + " " + byte.MaxValue);
    Console.WriteLine(float.MinValue + " " + float.MaxValue);
    Console.WriteLine(double.MinValue + " " + double.MaxValue);
    Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);
    Console.WriteLine(char.MinValue + " " + char.MaxValue);
    Console.WriteLine(bool.FalseString + " " + bool.TrueString);
}
