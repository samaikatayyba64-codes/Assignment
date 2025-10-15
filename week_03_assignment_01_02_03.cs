using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENU DISPATCHER =====");
        Console.WriteLine("1. Show Greeting");
        Console.WriteLine("2. Show Current Date");
        Console.WriteLine("3. Calculate Square");
        Console.WriteLine("4. Display Random Number");
        Console.WriteLine("5. Say Goodbye");
        Console.WriteLine("===========================");
        Console.Write("Choose an option (1–5): ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello! Welcome to CS-409 Lab.");
                    break;

                case 2:
                    Console.WriteLine($"Today is: {DateTime.Now:D}");
                    break;

                case 3:
                    Console.Write("Enter a number: ");
                    if (double.TryParse(Console.ReadLine(), out double n))
                        Console.WriteLine($"Square = {n * n}");
                    else
                        Console.WriteLine("Invalid number.");
                    break;

                case 4:
                    Random r = new Random();
                    Console.WriteLine($"Random number: {r.Next(1, 101)}");
                    break;

                case 5:
                    Console.WriteLine("Goodbye! Have a great day.");
                    break;

                default:
                    Console.WriteLine("Invalid menu option. Please run again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Input must be a number.");
        }
    }
}
using System;

class TicketPrice
{
    static void Main()
    {
        const double BasePrice = 1000.0;

        Console.Write("Enter your age: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
        {
            Console.WriteLine("Invalid age.");
            return;
        }

        Console.Write("Are you a student? (Y/N): ");
        string? s = Console.ReadLine()?.Trim().ToUpper();

        double discount = 0;

        // Decision table logic
        if (age < 12)
            discount = 50;
        else if (age >= 60)
            discount = 40;
        else if (s == "Y")
            discount = 25;
        else
            discount = 0;

        double finalPrice = BasePrice * (1 - discount / 100);

        Console.WriteLine($"Base Price: {BasePrice:C}");
        Console.WriteLine($"Discount: {discount}%");
        Console.WriteLine($"Final Ticket Price: {finalPrice:C}");
    }
}
using System;

class StringClassifier
{
    static void Main()
    {
        Console.Write("Enter a line: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Empty");
        }
        else if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Whitespace only");
        }
        else if (input.Length < 5)
        {
            Console.WriteLine("Short string");
        }
        else
        {
            Console.WriteLine("Long string");
        }
    }
}