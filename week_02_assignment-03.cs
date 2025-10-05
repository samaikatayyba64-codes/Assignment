using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class week_02_assignment_03
    {
    }
}
﻿//Read full name and city; print initials, name length, and a simple ID string. Demonstrates string splitting, trimming, casing, and 
//validation. 

using System;

class Program
{
    static void Main()
    {


        Console.Write("Full name: ");
        string? fullNameIn = Console.ReadLine();

        Console.Write("City: ");
        string? cityIn = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fullNameIn) || string.IsNullOrWhiteSpace(cityIn))
        {
            Console.WriteLine("Both name and city are required.");
            return;
        }

        string fullName = fullNameIn.Trim();
        string city = cityIn.Trim();

        // Split name by whitespace. Use first and last tokens for initials if available.
        string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        char firstInitial = char.ToUpperInvariant(parts[0][0]);
        char lastInitial = (parts.Length > 1)
            ? char.ToUpperInvariant(parts[^1][0]) // last token’s first character
            : '_'; // placeholder if no last name

        string initials = (lastInitial == '_')
            ? $"{firstInitial}."
            : $"{firstInitial}.{lastInitial}.";

        int nameLength = fullName.Length;


        string id = (lastInitial == '_')
            ? $"{city.ToUpperInvariant()}_{firstInitial}_{nameLength}"
            : $"{city.ToUpperInvariant()}_{firstInitial}{lastInitial}_{nameLength}";

        Console.WriteLine();
        Console.WriteLine($"Hello, {fullName} ({initials}) from {city}");
        Console.WriteLine($"Name length: {nameLength}");
        Console.WriteLine($"ID: {id}");
    }
}