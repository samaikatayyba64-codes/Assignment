//Objective: Create a flexible permission system using enum flags.

[Flags]
enum FilePermission { Read = 1, Write = 2, Execute = 4 }

class Program
{
    static void Main()
    {
        FilePermission user = FilePermission.Read | FilePermission.Write;

        Console.WriteLine($"Permissions: {user}");

        if ((user & FilePermission.Read) == FilePermission.Read)
            Console.WriteLine("Can read files");
    }
}
