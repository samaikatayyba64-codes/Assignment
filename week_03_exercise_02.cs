//Objective: Model character states in a game using enums.

enum CharacterStatus { Healthy, Poisoned, Paralyzed, Dead }

class Program
{
    static void Main()
    {
        CharacterStatus player = CharacterStatus.Healthy;
        player = CharacterStatus.Poisoned;

        Console.WriteLine($"Player status: {player}");

        if (player == CharacterStatus.Paralyzed ||
            player == CharacterStatus.Dead)
            Console.WriteLine("Cannot move!");
    }
}
