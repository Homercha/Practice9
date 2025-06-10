public class Settings
{
    private static Settings instance;

    private Settings() { }

    public static Settings Instance => instance ??= new Settings();

    public int WindowWidth { get; set; } = 800;
    public int WindowHeight { get; set; } = 600;
    public string Language { get; set; } = "uk-UA";
}
