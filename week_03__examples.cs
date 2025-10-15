using System;

Console.Write("Temperature: ");
string? tIn = Console.ReadLine();
Console.Write("Unit (C/F): ");
string? uIn = Console.ReadLine();

if (!double.TryParse(tIn, out double t) || string.IsNullOrWhiteSpace(uIn))
{
    Console.WriteLine("Invalid input.");
}
else
{
    char unit = char.ToUpperInvariant(uIn.Trim()[0]);
    bool isFreezing = (unit == 'C' && t <= 0) || (unit == 'F' && t <= 32);
    bool isHot = (unit == 'C' && t >= 30) || (unit == 'F' && t >= 86);

    if (isFreezing) Console.WriteLine("Freezing");
    else if (isHot) Console.WriteLine("Hot");
    else Console.WriteLine("Mild");
}




using System;

Console.Write("Percentage (0..100): ");
string? s = Console.ReadLine();

if (!int.TryParse(s, out int pct) || pct < 0 || pct > 100)
{
    Console.WriteLine("Enter a whole number in 0..100.");
    return;
}

string grade;
if (pct >= 85) grade = "A";
else if (pct >= 75) grade = "B";
else if (pct >= 65) grade = "C";
else if (pct >= 50) grade = "D";
else grade = "F";

Console.WriteLine($"Grade: {grade}");



using System;

Console.Write("Base price: ");
if (!double.TryParse(Console.ReadLine(), out double basePrice))
{
    Console.WriteLine("Bad price.");
    return;
}

Console.Write("Member (Y/N): ");
string? memIn = Console.ReadLine();
bool isMember = !string.IsNullOrWhiteSpace(memIn) &&
                char.ToUpperInvariant(memIn.Trim()[0]) == 'Y';

Console.Write("Day (Mon..Sun): ");
string? dayIn = Console.ReadLine();
if (string.IsNullOrWhiteSpace(dayIn))
{
    Console.WriteLine("Bad day.");
    return;
}
string day = dayIn.Trim().ToLowerInvariant();

bool isWeekend = (day == "sat" || day == "saturday" || day == "sun" || day == "sunday");

double discount = isMember ? (isWeekend ? 0.10 : 0.05) : 0.0;
double finalPrice = basePrice * (1 - discount);

Console.WriteLine($"Member: {isMember}, Weekend: {isWeekend}");
Console.WriteLine($"Discount: {discount * 100:F0}%");
Console.WriteLine($"Final price: {finalPrice:F2}");


using System;

Console.WriteLine("1) Add  2) Sub  3) Mul  4) Div  Q) Quit");
Console.Write("Choose: ");
string? choice = Console.ReadLine();

if (string.IsNullOrWhiteSpace(choice) || choice.Equals("Q", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Goodbye.");
    return;
}

Console.Write("A: ");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("Bad A.");
    return;
}

Console.Write("B: ");
if (!double.TryParse(Console.ReadLine(), out double b))
{
    Console.WriteLine("Bad B.");
    return;
}

switch (choice.Trim())
{
    case "1":
        Console.WriteLine($"Result = {a + b:F2}");
        break;
    case "2":
        Console.WriteLine($"Result = {a - b:F2}");
        break;
    case "3":
        Console.WriteLine($"Result = {a * b:F2}");
        break;
    case "4":
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            break;
        }
        Console.WriteLine($"Result = {a / b:F2}");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}


