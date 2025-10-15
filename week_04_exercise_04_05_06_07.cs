//Objective: Extract only required tuple elements.

using System.ComponentModel;

class Program
{
    static void Main()
    {
        var score = (Name: "R2-D2", Points: 12420, Level: 15);
        (string name, _, _) = score;
        Console.WriteLine($"Player: {name}");
    }
}


//Objective: Combine enumerations inside a tuple.

enum Recipe { Soup, Stew, Gumbo }
enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }

class Program
{
    static void Main()
    {
        var soup = (Recipe: Recipe.Gumbo, Ingredient: Ingredient.Chicken, Seasoning: Seasoning.Sweet);
        Console.WriteLine($"{soup.Seasoning} {soup.Ingredient} {soup.Recipe}");
    }
}



//Objective: Define a class with fields and create an instance.

class Score
{
    public string name;
    public int points;
    public int level;
}

class Program
{
    static void Main()
    {
        Score s = new Score();
        s.name = "R2-D2";
        s.points = 12420;
        s.level = 15;
        Console.WriteLine($"{s.name} - Level {s.level} - Points: {s.points}");
    }
}



//Objective: Add class methods that act on data.


class Score
{
    public string name;
    public int points;
    public int level;
    public bool EarnedStar() => (points / level) > 1000;
}
class Program
{
    static void Main()
    {
        Score s = new Score { name = "C-3PO", points = 8543, level = 9 };
        if (s.EarnedStar())
            Console.WriteLine($"{s.name} earned a star!");
    }
}
