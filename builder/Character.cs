public class Character
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public override string ToString()
    {
        return $"Сила: {Strength}, Спритність: {Agility}, Інтелект: {Intelligence}";
    }
}
