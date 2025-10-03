// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class TemperatureLogger
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

        foreach (int t in temps)
        {
            if (t < min) min = t;
            if (t > max) max = t;
            sum += t;
        }

        double avg = sum / (double)N;

        Console.WriteLine($"\nMin: {min}°, Max: {max}°, Average: {avg:F1}°");

        // Step 6: Optimized Histogram using Dictionary
        Console.WriteLine("\nHistogram:");
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int t in temps)
        {
            if (freq.ContainsKey(t))
                freq[t]++;
            else
                freq[t] = 1;
        }

        foreach (var kv in freq)
        {
            Console.Write($"{kv.Key}°: ");
            Console.WriteLine(new string('*', kv.Value));
        }
    }
}