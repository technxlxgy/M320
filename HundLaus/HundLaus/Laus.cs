public class Laus
{
    public string Name { get; }
    private Hund wirt;
    public Laus(string name, Hund hund)
    {
        Name = name;
        SetWirt(hund);
    }

    public void SetWirt(Hund hund)
    {
        wirt = hund;
    }

    public void LausOutput()
    {
        Console.WriteLine($" - Laus: {Name}, Wirt: {wirt.Name}");
    }
}