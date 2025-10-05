//Exercise 1 — Polite Greeter 
using System;

namespace PoliteGreeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Use Console.Write to prompt on the same line; read with Console.ReadLine
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine() ?? "";

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine() ?? "";

            // Step 2: Validate using string.IsNullOrWhiteSpace; print a clear error on bad input
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("Error: First name cannot be empty or whitespace.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Error: Last name cannot be empty or whitespace.");
                return;
            }

            // Step 3: Trim both names
            firstName = firstName.Trim();
            lastName = lastName.Trim();

            // Step 4: Take first chars, convert with char.ToUpperInvariant
            char firstInitial = char.ToUpperInvariant(firstName[0]);
            char lastInitial = char.ToUpperInvariant(lastName[0]);

            // Step 5: Print the greeting using string interpolation
            Console.WriteLine($"Hello, {firstName} {lastName} ({firstInitial}.{lastInitial}.)");
        }
    }
}

//Exercise 2 — Flexible Stats (loops only, no LINQ)
using System;

namespace FlexibleStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Initialize count = 0 and sum = 0; seed min and max after reading the first valid number
            int count = 0;
            int sum = 0;
            int min = 0;
            int max = 0;
            bool firstNumberRead = false;

            Console.WriteLine("Enter whole numbers (press Enter on blank line to finish):");

            // Step 2: While true: prompt, read a line; if empty → break
            while (true)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine() ?? "";

                // If empty line, break
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                // Step 3: If int.TryParse succeeds: update count/sum and min/max correctly
                if (int.TryParse(input.Trim(), out int number))
                {
                    count++;
                    sum += number;

                    // Seed min and max with first valid number
                    if (!firstNumberRead)
                    {
                        min = number;
                        max = number;
                        firstNumberRead = true;
                    }
                    else
                    {
                        if (number < min) min = number;
                        if (number > max) max = number;
                    }
                }
                // Step 4: Else: print an error and re-prompt
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid whole number.");
                }
            }

            // Step 5: If count > 0: compute avg = sum / (double)count and print all stats
            if (count > 0)
            {
                double avg = sum / (double)count;

                Console.WriteLine("\n=== STATISTICS ===");
                Console.WriteLine($"Count: {count}");
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Min: {min}");
                Console.WriteLine($"Max: {max}");
                Console.WriteLine($"Average: {avg:F2}");

                // Stretch ideas: Count evens and odds
                Console.WriteLine("\n=== ADDITIONAL STATS ===");
                int evens = 0;
                int odds = 0;

                // Note: We can't re-read the numbers, so this is a simplified demonstration
                // In a real implementation, you'd store numbers in a list or array
                Console.WriteLine("(Note: Even/Odd count would require storing all numbers)");
                Console.WriteLine($"Total numbers processed: {count}");
            }
            else
            {
                Console.WriteLine("No valid numbers were entered.");
            }
        }
    }
}
