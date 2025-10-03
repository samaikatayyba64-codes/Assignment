using System;

class ProfileProgram
{
    static void Main()
    {
        // Step 1: Name input and validation
        Console.Write("Enter your name: ");
        string? nameInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nameInput))
        {
            Console.WriteLine("Invalid input: Name cannot be empty or whitespace.");
            return;
        }
        string name = nameInput.Trim();

        // Step 2: City input and validation
        Console.Write("Enter your city: ");
        string? cityInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(cityInput))
        {
            Console.WriteLine("Invalid input: City cannot be empty or whitespace.");
            return;
        }
        string city = cityInput.Trim();

        // Step 3: Age input and validation
        Console.Write("Enter your age: ");
        string? ageTextInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(ageTextInput))
        {
            Console.WriteLine("Invalid input: Age cannot be empty.");
            return;
        }
        string ageText = ageTextInput.Trim();

        if (!int.TryParse(ageText, out int age) || age < 0 || age > 150)
        {
            Console.WriteLine("Invalid input: Age must be a valid number between 0 and 150.");
            return;
        }

        // Step 4: Print profile summary
        Console.WriteLine();
        Console.WriteLine("=== PROFILE SUMMARY ===");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);

        // Step 5: Calculate and print initials
        string initials = GetInitials(name);
        Console.WriteLine("Initials: " + initials);

        // Step 6: Greeting message
        Console.WriteLine("Hello " + name + "! Welcome from " + city + "!");
    }

    static string GetInitials(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "";

        string[] parts = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string initials = "";

        foreach (string part in parts)
        {
            initials += char.ToUpper(part[0]);
        }

        return initials;
    }
}
