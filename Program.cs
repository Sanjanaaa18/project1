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

sampleproblem sampleproblem =new sampleproblem();
sampleproblem.sample();
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