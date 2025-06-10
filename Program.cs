using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== Singleton: Logger ==");
        Logger.Instance.AddLog("Програма запущена");
        Logger.Instance.AddLog("Виконано вхід користувача");

        foreach (var log in Logger.Instance.GetLogs())
        {
            Console.WriteLine(log);
        }

        Console.WriteLine("\n== Singleton: Settings ==");
        Settings.Instance.Language = "en-US";
        Settings.Instance.WindowWidth = 1024;

        Console.WriteLine($"Language: {Settings.Instance.Language}");
        Console.WriteLine($"Window: {Settings.Instance.WindowWidth}x{Settings.Instance.WindowHeight}");
    }
}
