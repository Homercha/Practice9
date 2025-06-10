using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== Builder: Character ==");
        var hero = new CharacterBuilder()
            .SetStrength(12)
            .SetAgility(9)
            .SetIntelligence(7)
            .Build();

        Console.WriteLine(hero);

        Console.WriteLine("\n== Builder: SQL Query ==");
        var query = new SqlQueryBuilder()
            .Select("Name, Email")
            .From("Users")
            .Where("Active = 1")
            .OrderBy("Name")
            .Build();

        Console.WriteLine(query);
    }
}
