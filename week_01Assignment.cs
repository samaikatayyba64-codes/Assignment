//Assignment 1 — Profile Summary (CLI)
using System;

class Program
{
    static void Main()
    {
        // Step 1: Prompt and read name and city; validate not empty or whitespace
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid input: Name cannot be empty or whitespace.");
            return;
        }

        Console.Write("Enter your city: ");
        string city = Console.ReadLine()!.Trim();

        if (string.IsNullOrWhiteSpace(city))
        {
            Console.WriteLine("Invalid input: City cannot be empty or whitespace.");
            return;
        }

        // Step 2: Prompt and read ageText; use int.TryParse and check sensible range
        Console.Write("Enter your age: ");
        string ageText = Console.ReadLine()!.Trim();

        // Step 3: If any input is invalid: print a message and stop
        if (!int.TryParse(ageText, out int age) || age < 0 || age > 150)
        {
            Console.WriteLine("Invalid input: Age must be a valid number between 0 and 150.");
            return;
        }

        // Step 4: Print the three labeled lines using interpolation
        Console.WriteLine();
        Console.WriteLine("=== PROFILE SUMMARY ===");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"City: {city}");

        // Stretch ideas implementation
        // Add initials next to the name
        string initials = GetInitials(name);
        Console.WriteLine($"Initials: {initials}");

        // Add a greeting sentence using string interpolation
        Console.WriteLine($"Hello {name}! Welcome from {city}!");
    }

    // Helper method to extract initials from name
    static string GetInitials(string name)
    {
        string[] nameParts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string initials = "";

        foreach (string part in nameParts)
        {
            if (part.Length > 0)
            {
                initials += part[0].ToString().ToUpper();
            }
        }

        return initials;
    }
}

//Assignment 2 — Temperature Logger 
using System;

class Program
{
    static void Main()
    {
        // Step 1: Read and validate N > 0
        Console.Write("Enter number of temperature readings: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Invalid input: N must be greater than 0.");
            return;
        }

        // Step 2: Create array
        int[] temps = new int[N];

        // Step 3: Read temperatures with validation
        for (int i = 0; i < N; i++)
        {
            while (true)
            {
                Console.Write($"Enter temperature {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out temps[i]))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        // Step 4 & 5: Calculate stats
        int min = temps[0], max = temps[0], sum = 0;

        for (int i = 0; i < N; i++)
        {
            if (temps[i] < min) min = temps[i];
            if (temps[i] > max) max = temps[i];
            sum += temps[i];
        }

        double avg = sum / (double)N;

        // Print results
        Console.WriteLine($"\nMin: {min}°, Max: {max}°, Average: {avg:F1}°");

        // Step 6: Simple histogram
        Console.WriteLine("\nHistogram:");
        for (int i = 0; i < N; i++)
        {
            int count = 0;
            for (int j = 0; j < N; j++)
            {
                if (temps[j] == temps[i]) count++;
            }

            // Print only once per unique temperature
            bool alreadyPrinted = false;
            for (int k = 0; k < i; k++)
            {
                if (temps[k] == temps[i])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (!alreadyPrinted)
            {
                Console.Write($"{temps[i]}°: ");
                for (int s = 0; s < count; s++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
