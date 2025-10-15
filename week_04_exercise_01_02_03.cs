//Objective: Create and access a tuple’s elements.

using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        (string, int, int) score = ("R2-D2", 12420, 15);

        Console.WriteLine($"Name: {score.Item1}");
        Console.WriteLine($"Points: {score.Item2}");
        Console.WriteLine($"Level: {score.Item3}");
    }
}


//Objective: Use named tuple elements for readability.

class Program
{
    static void Main()
    {
        var player = (Name: "C-3PO", Points: 8543, Level: 9);
        Console.WriteLine($"{player.Name} reached Level {player.Level} with {player.Points} points.");
    }
}



//Objective: Return and deconstruct tuples from a method.


class Program
{
    static (string, int, int) GetScore()
    {
        return ("GONK", -1, 1);
    }

    static void Main()
    {
        (string name, int points, int level) = GetScore();
        Console.WriteLine($"{name} reached Level {level} with {points} points.");
    }
}
