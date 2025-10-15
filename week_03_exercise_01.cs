//Objective: Create a traffic light simulation using enums.
enum TrafficLight { Red, Yellow, Green }

class Program
{
    static void Main()
    {
        TrafficLight current = TrafficLight.Red;

        Console.WriteLine($"Current light: {current}");
        current = TrafficLight.Green;
        Console.WriteLine($"Current light: {current}");

        if (current == TrafficLight.Green)
            Console.WriteLine("Safe to proceed!");
    }
}
