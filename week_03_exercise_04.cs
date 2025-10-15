//Objective: Use enums with custom underlying values.

enum DayOfWeek
{
    Monday = 1, Tuesday, Wednesday,
    Thursday, Friday, Saturday, Sunday
}

class Program
{
    static void Main()
    {
        DayOfWeek today = DayOfWeek.Wednesday;

        Console.WriteLine($"Today is {today} (day {(int)today})");

        if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            Console.WriteLine("Weekend!");
    }
}
